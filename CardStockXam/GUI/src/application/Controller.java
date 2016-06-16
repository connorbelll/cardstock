package application;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.scene.control.*;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.layout.AnchorPane;
import javafx.stage.FileChooser;
import model.*;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;

public class Controller {

    @FXML
    TextField errorField;

    @FXML
    TextField currentMoveField;

    @FXML
    TextField currentTurn;

    @FXML
    TextField moveDesc;

    @FXML
    TableView<RawStorage> infoTable;

    @FXML
    TableView<Memory> memoryTable;

    @FXML
    AnchorPane pane;

    @FXML
    Button forward;

    @FXML
    Button backward;

    @FXML
    ChoiceBox<Integer> gameSelect;

    private Game currentGame;
    private int numPlayers;
    private int currentMove;
    private ArrayList<Move> moves;
    private ArrayList<Game> games;
    private Table table;
    private String STOCKNAME = "{hidden}STOCK";
    private int turn = 0;

    @FXML
    public void initialize() {
        infoTable.setEditable(false);
        gameSelect.getSelectionModel().selectedIndexProperty().addListener((v,vOld,vNew) -> {
            int choice = vNew.intValue();
            if (choice >= 0) {
                currentGame = games.get(choice);
                clearCanvas();
                newGame();
            }
        });
    }

    @FXML
    private void newGame() {
        this.numPlayers = currentGame.numPlayers;
        this.moves = currentGame.moves;
        this.table = currentGame.table;

        currentMove = 0;
        table.setLocs();
        setupInfoTable(currentGame.rawInfo, currentGame.memInfo);
        paint();
    }

    @FXML
    public void forward() {
        if (currentGame != null) {
            if (currentMove < moves.size()) {
                Move move = moves.get(currentMove);
                currentMove++;
                String transcript = move.execute();
                moveDesc.setText(transcript);
                System.out.println(transcript);
                paint();
            }
        }
        else {
            errorField.setText("No game selected");
        }
    }

    @FXML
    public void backward() {
        if (currentGame != null) {
            if (currentMove > 0) {
                Move move = moves.get(currentMove - 1);
                currentMove--;
                String transcript = move.revert();
                moveDesc.setText(transcript);
                paint();
            }
        }
        else {
            errorField.setText("No game selected");
        }
    }

    public void openDataFile() {
        errorField.setText("Opening");
        File dataFile = getDataFile();
        if (dataFile != null) {
            try {
                errorField.setText("Adding games");
                games = parseDataFrom(dataFile);
                //games = protoParseDataFrom(dataFile);
            } catch (IOException e) {
                errorField.setText(e.toString());
                e.printStackTrace();
            }
            gameSelect.getItems().clear();
            clearCanvas();
            addGames();
        }
        else {
            errorField.setText("Invalid file");
        }
    }

    private void clearCanvas() {
        errorField.setText("All good");
        pane.getChildren().clear();

    }

    private void addGames() {
        for (int i = 1; i <= games.size(); i++) {
            gameSelect.getItems().add(i);
        }
    }

    private void setupInfoTable(ObservableList<RawStorage> info, ObservableList<Memory> memInfo) {
        TableColumn<RawStorage, String> locColumn = new TableColumn<>("Location");
        locColumn.setMinWidth(125);
        locColumn.setCellValueFactory(new PropertyValueFactory<>("Loc"));
        TableColumn<RawStorage, String> keyColumn = new TableColumn<>("Key");
        keyColumn.setMinWidth(75);
        keyColumn.setCellValueFactory(new PropertyValueFactory<>("Key"));
        TableColumn<RawStorage, String> valueColumn = new TableColumn<>("Value");
        valueColumn.setMinWidth(50);
        valueColumn.setCellValueFactory(new PropertyValueFactory<>("Value"));
        infoTable.getColumns().clear();
        infoTable.getColumns().addAll(locColumn, keyColumn, valueColumn);
        infoTable.setColumnResizePolicy(TableView.CONSTRAINED_RESIZE_POLICY);
        infoTable.setItems(info);
        infoTable.setPrefWidth(300);

        TableColumn<Memory, String> newKeyColumn = new TableColumn<>("Key");
        newKeyColumn.setMinWidth(100);
        newKeyColumn.setCellValueFactory(new PropertyValueFactory<>("Key"));
        TableColumn<Memory, String> cardColumn = new TableColumn<>("Card");
        cardColumn.setMinWidth(200);
        cardColumn.setCellValueFactory(new PropertyValueFactory<>("Card"));
        memoryTable.getColumns().clear();
        memoryTable.getColumns().addAll(newKeyColumn, cardColumn);
        memoryTable.setColumnResizePolicy(TableView.CONSTRAINED_RESIZE_POLICY);
        memoryTable.setItems(memInfo);
        memoryTable.setPrefWidth(300);
    }

    private void paint() {
        pane.getChildren().clear();
        if (currentMove < moves.size()) {
            int oldTurn = turn;
            turn = moves.get(currentMove).getCurrentPlayer();
            currentTurn.setText("Current turn: Player " + turn);
            if (oldTurn != turn) {
                table.paintCurrentTurn(oldTurn, turn);
            }
        }
        table.paint(pane);
        currentMoveField.setText("Current move: " + currentMove);
    }


    private ArrayList<Game> parseDataFrom(File dataFile) throws IOException {
        errorField.setText("Parsing..");
        FileReader fileReader = new FileReader(dataFile);
        BufferedReader reader = new BufferedReader(fileReader);

        ArrayList<Cards> cardLocs = new ArrayList<>();
        ArrayList<Move> currentMoves = new ArrayList<>();
        ObservableList<RawStorage> rawInfo = FXCollections.observableArrayList();
        ArrayList<Game> result = new ArrayList<>();
        int scoreNum = 0;
        int numGamesRead = 0;
        int nextMoveTurn = -1;


        String line = reader.readLine();
        numPlayers = Integer.valueOf(line.split(":")[1]);
        Table newTable = setupTable();
        newTable.addToTable(new Cards(STOCKNAME, false));

        while ((line = reader.readLine()) != null) {
            char lineId = line.charAt(0);
            if (line.length() > 1) {line = line.split(":")[1];}

            if (lineId == 'T') { //Team
                String[] players = line.split(" ");
                String team = "";
                for (int i = 0; i < players.length; i++) {
                    team += players[i] + " ";
                }
                RawStorage stor = new RawStorage("CardEngine.RawStorage", "Team", team.trim());
                rawInfo.add(stor);
            }

            else if (lineId == 'C') { //Card
                Card newCard = getCard(line);
                newTable.addToTable(newCard, STOCKNAME);
            }
            else if (lineId == 'M') { //Move
                String[] parts = line.split(" ");
                Card card = getCard(parts[0]);
                Location startLoc = getLocation(parts[1], newTable);
                Location endLoc = getLocation(parts[2], newTable);
                Move newMove = new Move(card, startLoc, endLoc);
                /*if (currentMoves.size() != 0) {
                    int currentPlayer = lastMove(currentMoves).getCurrentPlayer();
                    newMove.setCurrentPlayer(currentPlayer);
                }
                else {newMove.setCurrentPlayer(0);}*/
                if (nextMoveTurn != -1) {
                    newMove.setCurrentPlayer(nextMoveTurn);
                    nextMoveTurn = -1;
                }
                else {
                    int tempP = lastMove(currentMoves).getCurrentPlayer();
                    newMove.setCurrentPlayer(tempP);
                }
                currentMoves.add(newMove);
            }

            /*
            else if (lineId == 'm') { //Memory storage TODO
                String[] parts = line.split(" ");
                String key = parts[0];
                Card card = getCard(parts[1]);
                currentMoves.add(new Move(memoryTable, new Memory(key, card));
            }
             */

            else if (lineId == 'A') { //Assignment
                String[] parts = line.split(" ");
                newTable.addValueToCards("reward", parts[0], parts[1]);
            }

            else if (lineId == 'S') { //Storage
                String[] parts = line.split(" ");
                String loc   = parts[0];
                String key   = parts[1];
                String value = parts[2];
                RawStorage stor = new RawStorage(loc, key, value);
                Move newMove = new Move(infoTable, stor);
                currentMoves.add(newMove);
            }

            else if (lineId == 't') { //current player (turn)
                nextMoveTurn = Character.getNumericValue(line.charAt(1));
                /*Move move = lastMove(currentMoves);
                if (move != null) {
                    move.setCurrentPlayer(Character.getNumericValue(line.charAt(1)));
                }*/
            }

            else if (lineId == 's') { //Score
                String[] parts = line.split(" ");
                String score = parts[0];
                String won = parts[1];
                String suffix = "lost";
                if (won.equals("1")) {suffix = "won";}
                RawStorage stor = new RawStorage("Player " + scoreNum, score, suffix);
                scoreNum++;
                Move newMove = new Move(infoTable, stor);
                currentMoves.add(newMove);
            }

            else if (lineId == '|') { //End of game
                result.add(new Game(numPlayers, newTable, rawInfo, cardLocs, currentMoves));
                cardLocs = new ArrayList<>();
                newTable = setupTable();
                currentMoves = new ArrayList<>();
                rawInfo = FXCollections.observableArrayList();
                scoreNum = 0;
                numGamesRead ++;
                nextMoveTurn = -1;
                if (numGamesRead % 10 == 0) {
                    errorField.setText("Parsing.. " + numGamesRead + " games read");
                }
            }
        }
        reader.close();
        return result;
    }

    private Card getCard(String line) {
        String[] parts = line.split("\\|");
        Card ret = new Card();
        for (String part : parts) {
            String[] attrs = part.split("-");
            ret.addAttribute(attrs[1],attrs[0]);
        }
        return ret;
    }

    private Move lastMove(ArrayList<Move> moves) {
        if (moves.size() == 0) {return null;}
        return moves.get(moves.size()-1);
    }

    private Location getLocation(String line, Table newTable) {
        char id = line.charAt(0);
        if (id == 't') { //table
            Cards cards = newTable.getTableCards(line.substring(1));
            if (cards == null) {
                newTable.addNewTableGroup(line.substring(1));
            }
            return new Location(newTable, line.substring(1));
        }
        else if (id == 'p') { //player
            int playerId = Character.getNumericValue(line.charAt(1));
            Player p = newTable.getPlayer(playerId);
            if (p != null) {
                return new Location(newTable, line.substring(2), playerId);
            }
            else {
                error("bad player: " + playerId);
            }
        }
        else {
            error("unknown line: " + line);
        }
        return null;
    }

    private File getDataFile() {
        FileChooser chooser = new FileChooser();
        chooser.setTitle("Select test data");
        return chooser.showOpenDialog(null);
    }

    private Table setupTable() {
        Table ret = new Table();
        for (int i = 0; i < numPlayers; i++) {
            ret.addPlayer(new Player(i));
        }
        return ret;
    }

    private void error(String text) {
        errorField.setText(text);
        System.out.println(text);
    }
}
