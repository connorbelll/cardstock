grammar CardLanguage;

stage : OPEN 'stage' ('game'|'player'|'team') endcondition (computermoves|playermoves|stage)+? CLOSE ;
endcondition : OPEN 'end' (boolean | (('game'|'player'|'team') int)) CLOSE ;

computermoves : OPEN 'comp' multigameaction CLOSE ;
playermoves : OPEN 'choice' multigameaction CLOSE ;

multigameaction : gameaction+? ;
gameaction : OPEN boolean multiaction CLOSE ;
multiaction : action+? ;

action : OPEN (init | loccreate | storagecreate | setaction | moveaction | copyaction | incaction | decaction | removeaction | turnaction | shuffleaction ) CLOSE ;

loccreate : 'create' 'loc' obj locationdef+? ;
locationdef : OPEN name ('Stack'|'List'|'Queue') ('Memory')? CLOSE ;

storagecreate : 'create' 'sto' obj OPEN name+? CLOSE ;

obj : ('player'|'game'|'team') ;


init : 'initialize'  (playerinit | deckinit | pointsinit) ;
playerinit : 'players' int int ('alternate' | 'sequential') ;
deckinit : locstorage deck ;
deck : OPEN 'permdeck' attribute+? CLOSE ;
attribute : (OPEN trueany+? attribute*? CLOSE)  ;

pointsinit : 'points' name OPEN awards+? CLOSE ;
awards : OPEN posq OPEN name ((OPEN trueany CLOSE) |(cardatt)) CLOSE int CLOSE ;


setaction : 'set' ('next' | 'current' | rawstorage) int ;
incaction : 'inc' rawstorage int ;
decaction : 'dec' rawstorage int ;

moveaction : 'move' card card (int | 'all')?;
copyaction : 'copy' card card (int | 'all')? ;
turnaction : 'turn' ('over' | 'pass') ;
removeaction : 'remove' card ;
shuffleaction : 'shuffle' locstorage ;
createaction : createsto ;
createsto : 'create' 'sto' (who | who2) namelist ;

namelist : OPEN name+? CLOSE ;
loclist : OPEN loc+? CLOSE ;
loc : OPEN name ('List' | 'Stack' | 'Queue') imag? CLOSE ;
imag : 'Memory' ;

card : maxof | (OPEN ('top' | 'bottom' | int | 'any') locstorage CLOSE);
owner : OPEN 'owner' card CLOSE;
rawstorage : OPEN (who | who2) 'sto' namegr CLOSE ;
locstorage : unionof | OPEN (who | who2) 'loc' name whereclause? CLOSE ;
who : 'game' ;
who2 : OPEN (posq | int | 'next' | 'current' | who2) ('player' | 'team') CLOSE ;

trueany : (ANY|int|BOOLOP)+?;
whereclause : 'where' boolatt ; 
boolatt : OPEN attrcomp CLOSE;

attrcomp : EQOP cardatt cardatt ;
cardatt : name | (OPEN 'cardatt' name ('this' | card ) CLOSE) ;
 
posq : 'any'| 'all' ;

boolean : (OPEN ((BOOLOP boolean boolean+?) | attrcomp | (intop int  int) | (UNOP boolean)) CLOSE) | (OPEN CLOSE) ;
BOOLOP : 'and' | 'or' ;
intop : (COMPOP | EQOP) ;
COMPOP : '<' | '>' | '>=' | '<=' ;
EQOP : '!=' | '==' ;
UNOP : 'not' ;

mult : OPEN '*' int int CLOSE ;
subtract : OPEN '-' int int CLOSE ;
mod : OPEN '%' int int CLOSE ;
divide : OPEN '//' int int CLOSE ;


sizeof : OPEN 'size' locstorage CLOSE ;
maxof : OPEN 'max' locstorage 'using' namegr CLOSE ;
unionof : OPEN 'union' locstorage+? CLOSE ;
sum : OPEN 'sum' rawstorage CLOSE ; 

int : owner | sizeof | mult | subtract | mod | divide | sum | rawstorage | INTNUM+ ;
INTNUM : [0-9] ;
namegr : ANY+ ;
name : ANY+? ;
OPEN : '(' ;
CLOSE : ')' ;
WS: [ \n\t\r]+ -> skip;
ANY : . ;

