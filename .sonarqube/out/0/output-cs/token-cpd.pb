??
`C:\Users\Benjimon41\Desktop\letsgetthisdubbbaby\Verificador_Precios\Verificador_Precios\Form1.cs
	namespace 	
Verificador_Precios
 
{ 
public		 

partial		 
class		 
Form1		 
:		  
Form		! %
{

 
private 
int 
segundos 
= 
$num  
;  !
private 
String 
codigo 
= 
$str  "
;" #
public 
Form1 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 

Form1_Load 
(  
object  &
sender' -
,- .
	EventArgs/ 8
e9 :
): ;
{ 	
img_outcome 
. 
SizeMode  
=! "
PictureBoxSizeMode# 5
.5 6
StretchImage6 B
;B C
img_outcome 
. 
Visible 
=  !
false" '
;' (

lb_outcome 
. 
Visible 
=  
false! &
;& '
lb_outcome_text 
. 
Visible #
=$ %
false& +
;+ ,
lb_porfavor3 
. 
Visible  
=! "
false# (
;( )
lb_porfavor3 
. 
Location !
=" #
new$ '
Point( -
(- .
this. 2
.2 3
Width3 8
/9 :
$num; <
-= >
lb_porfavor3? K
.K L
WidthL Q
/R S
$numT U
,U V
thisW [
.[ \
Height\ b
-c d
$nume h
)h i
;i j
img_producto 
. 
Location !
=" #
new$ '
Point( -
(- .
this. 2
.2 3
Width3 8
-9 :
$num; >
,> ?
this@ D
.D E
HeightE K
/L M
$numN O
-P Q
$numR T
)T U
;U V
lb_desc_desc 
. 
Location !
=" #
new$ '
Point( -
(- .
this. 2
.2 3
Width3 8
-9 :
$num; >
,> ?
this@ D
.D E
HeightE K
-L M
$numN Q
)Q R
;R S
lb_descP 
. 
Location 
= 
new  #
Point$ )
() *
this* .
.. /
Width/ 4
-5 6
$num7 :
,: ;
this< @
.@ A
HeightA G
-H I
$numJ M
)M N
;N O
lb_desc_nombre 
. 
Location #
=$ %
new& )
Point* /
(/ 0
$num0 3
,3 4
$num5 8
)8 9
;9 :
lb_desc_precio 
. 
Location #
=$ %
new& )
Point* /
(/ 0
$num0 3
,3 4
$num5 8
)8 9
;9 :
lb_desc_stock   
.   
Location   "
=  # $
new  % (
Point  ) .
(  . /
$num  / 2
,  2 3
$num  4 7
)  7 8
;  8 9

lb_nombreP!! 
.!! 
Location!! 
=!!  !
new!!" %
Point!!& +
(!!+ ,
$num!!, /
,!!/ 0
$num!!1 4
)!!4 5
;!!5 6

lb_precioP"" 
."" 
Location"" 
=""  !
new""" %
Point""& +
(""+ ,
$num"", /
,""/ 0
$num""1 4
)""4 5
;""5 6
	lb_stockP## 
.## 
Location## 
=##  
new##! $
Point##% *
(##* +
$num##+ .
,##. /
$num##0 3
)##3 4
;##4 5
lb_porfavor$$ 
.$$ 
Location$$  
=$$! "
new$$# &
Point$$' ,
($$, -
this$$- 1
.$$1 2
Width$$2 7
/$$8 9
$num$$: ;
-$$< =
lb_porfavor$$> I
.$$I J
Width$$J O
/$$P Q
$num$$R S
,$$S T
img_logo$$U ]
.$$] ^
Height$$^ d
+$$e f
$num$$g j
)$$j k
;$$k l
lb_porfavor2%% 
.%% 
Location%% !
=%%" #
new%%$ '
Point%%( -
(%%- .
this%%. 2
.%%2 3
Width%%3 8
/%%9 :
$num%%; <
-%%= >
lb_porfavor2%%? K
.%%K L
Width%%L Q
/%%R S
$num%%T U
,%%U V
lb_porfavor%%W b
.%%b c
Height%%c i
+%%j k
lb_porfavor%%l w
.%%w x
Location	%%x ?
.
%%? ?
Y
%%? ?
+
%%? ?
$num
%%? ?
)
%%? ?
;
%%? ?
img_barcode&& 
.&& 
Location&&  
=&&! "
new&&# &
Point&&' ,
(&&, -
this&&- 1
.&&1 2
Width&&2 7
/&&8 9
$num&&: ;
-&&< =
img_barcode&&> I
.&&I J
Width&&J O
/&&P Q
$num&&R S
,&&S T
this&&U Y
.&&Y Z
Height&&Z `
/&&a b
$num&&c d
)&&d e
;&&e f
Inicio'' 
('' 
sender'' 
,'' 
e'' 
)'' 
;'' 
}(( 	
private** 
void** 
Ocultar** 
(** 
object** #
sender**$ *
,*** +
	EventArgs**, 5
e**6 7
,**7 8
Boolean**8 ?
mostrar**@ G
)**G H
{++ 	
lb_desc_nombre-- 
.-- 
Visible-- "
=--# $
mostrar--% ,
;--, -
lb_desc_precio.. 
... 
Visible.. "
=..# $
mostrar..% ,
;.., -
lb_desc_stock// 
.// 
Visible// !
=//" #
mostrar//$ +
;//+ ,
lb_desc_desc00 
.00 
Visible00  
=00! "
mostrar00# *
;00* +
img_producto22 
.22 
Visible22  
=22! "
mostrar22# *
;22* +
lb_descP33 
.33 
Visible33 
=33 
mostrar33 &
;33& '

lb_nombreP44 
.44 
Visible44 
=44  
mostrar44! (
;44( )

lb_precioP55 
.55 
Visible55 
=55  
mostrar55! (
;55( )
	lb_stockP66 
.66 
Visible66 
=66 
mostrar66  '
;66' (
}88 	
private99 
void99 
Inicio99 
(99 
object99 "
sender99# )
,99) *
	EventArgs99+ 4
e995 6
)996 7
{:: 	
Ocultar;; 
(;; 
sender;; 
,;; 
e;; 
,;; 
false;; $
);;$ %
;;;% &
img_logo<< 
.<< 
Location<< 
=<< 
new<<  #
Point<<$ )
(<<) *
this<<* .
.<<. /
Width<</ 4
/<<5 6
$num<<7 8
-<<9 :
img_logo<<; C
.<<C D
Width<<D I
/<<J K
$num<<L M
,<<M N
$num<<O R
)<<R S
;<<S T
lb_porfavor== 
.== 
Visible== 
===  !
true==" &
;==& '
lb_porfavor2>> 
.>> 
Visible>>  
=>>! "
true>># '
;>>' (
img_barcode?? 
.?? 
Visible?? 
=??  !
true??" &
;??& '
}@@ 	
privateBB 
voidBB 
	ResultadoBB 
(BB 
objectBB %
senderBB& ,
,BB, -
	EventArgsBB. 7
eBB8 9
,BB9 :
intBB; >
estadoBB? E
)BBE F
{CC 	
lb_outcome_textDD 
.DD 
VisibleDD #
=DD$ %
trueDD& *
;DD* +
img_logoEE 
.EE 
LocationEE 
=EE 
newEE  #
PointEE$ )
(EE) *
thisEE* .
.EE. /
WidthEE/ 4
-EE5 6
img_logoEE7 ?
.EE? @
WidthEE@ E
-EEF G
$numEEH K
,EEK L
$numEEM P
)EEP Q
;EEQ R
lb_porfavorFF 
.FF 
VisibleFF 
=FF  !
falseFF" '
;FF' (
lb_porfavor2GG 
.GG 
VisibleGG  
=GG! "
falseGG# (
;GG( )
img_barcodeHH 
.HH 
VisibleHH 
=HH  !
falseHH" '
;HH' (
lb_porfavor3II 
.II 
VisibleII  
=II! "
trueII# '
;II' (
img_outcomeJJ 
.JJ 
VisibleJJ 
=JJ  !
trueJJ" &
;JJ& '

lb_outcomeKK 
.KK 
VisibleKK 
=KK  
trueKK! %
;KK% &
ifLL 
(LL 
estadoLL 
==LL 
$numLL 
)LL 
{LL 
lb_outcome_textMM 
.MM  
VisibleMM  '
=MM( )
falseMM* /
;MM/ 0
OcultarNN 
(NN 
senderNN 
,NN 
eNN  !
,NN! "
trueNN# '
)NN' (
;NN( )

lb_outcomeOO 
.OO 
LocationOO #
=OO$ %
newOO& )
PointOO* /
(OO/ 0
$numOO0 3
,OO3 4
$numOO5 8
)OO8 9
;OO9 :
img_outcomePP 
.PP 
LocationPP $
=PP% &
newPP' *
PointPP+ 0
(PP0 1
$numPP1 4
,PP4 5
$numPP6 9
)PP9 :
;PP: ;
img_outcomeQQ 
.QQ 
SizeQQ  
=QQ! "
newQQ# &
SizeQQ' +
(QQ+ ,
$numQQ, /
,QQ/ 0
$numQQ1 3
)QQ3 4
;QQ4 5
img_outcomeRR 
.RR 
ImageRR !
=RR" #

PropertiesRR$ .
.RR. /
	ResourcesRR/ 8
.RR8 9"
exito_removebg_previewRR9 O
;RRO P

lb_outcomeSS 
.SS 
TextSS 
=SS  !
$strSS" 6
;SS6 7

lb_outcomeTT 
.TT 
	ForeColorTT $
=TT% &
SystemTT' -
.TT- .
DrawingTT. 5
.TT5 6
ColorTT6 ;
.TT; <
GreenTT< A
;TTA B
}VV 
elseWW 
{XX 
OcultarYY 
(YY 
senderYY 
,YY 
eYY  !
,YY! "
falseYY# (
)YY( )
;YY) *
img_outcomeZZ 
.ZZ 
SizeZZ  
=ZZ! "
newZZ# &
SizeZZ' +
(ZZ+ ,
$numZZ, /
,ZZ/ 0
$numZZ1 4
)ZZ4 5
;ZZ5 6
img_outcome[[ 
.[[ 
Location[[ $
=[[% &
new[[' *
Point[[+ 0
([[0 1
this[[1 5
.[[5 6
Width[[6 ;
/[[; <
$num[[< =
-[[> ?
img_outcome[[@ K
.[[K L
Width[[L Q
/[[Q R
$num[[R S
,[[S T
$num[[U X
)[[X Y
;[[Y Z
if]] 
(]] 
estado]] 
==]] 
$num]] 
)]]  
{^^ 

lb_outcome`` 
.`` 
Text`` #
=``$ %
$str``& :
;``: ;

lb_outcomeaa 
.aa 
	ForeColoraa (
=aa) *
Systemaa+ 1
.aa1 2
Drawingaa2 9
.aa9 :
Coloraa: ?
.aa? @
Redaa@ C
;aaC D
lb_outcome_textbb #
.bb# $
Textbb$ (
=bb) *
$str	bb+ ?
;
bb? ?
img_outcomecc 
.cc  
Imagecc  %
=cc& '

Propertiescc( 2
.cc2 3
	Resourcescc3 <
.cc< ="
error_removebg_previewcc= S
;ccS T
}dd 
elseee 
{ff 

lb_outcomehh 
.hh 
Texthh #
=hh$ %
$strhh& F
;hhF G

lb_outcomeii 
.ii 
	ForeColorii (
=ii) *
Systemii+ 1
.ii1 2
Drawingii2 9
.ii9 :
Colorii: ?
.ii? @
Yellowii@ F
;iiF G
lb_outcome_textjj #
.jj# $
Textjj$ (
=jj) *
$str	jj+ ?
;
jj? ?
img_outcomekk 
.kk  
Imagekk  %
=kk& '

Propertieskk( 2
.kk2 3
	Resourceskk3 <
.kk< =#
alerta_removebg_previewkk= T
;kkT U
}ll 

lb_outcomemm 
.mm 
Locationmm #
=mm$ %
newmm& )
Pointmm* /
(mm/ 0
thismm0 4
.mm4 5
Widthmm5 :
/mm; <
$nummm= >
-mm? @

lb_outcomemmA K
.mmK L
WidthmmL Q
/mmR S
$nummmT U
,mmU V
$nummmW Z
)mmZ [
;mm[ \
lb_outcome_textnn 
.nn  
Locationnn  (
=nn) *
newnn+ .
Pointnn/ 4
(nn4 5
thisnn5 9
.nn9 :
Widthnn: ?
/nn@ A
$numnnB C
-nnD E
lb_outcome_textnnF U
.nnU V
WidthnnV [
/nn\ ]
$numnn^ _
,nn_ `
$numnna d
)nnd e
;nne f
}pp 
}tt 	
privateyy 
voidyy 
Form1_KeyPressyy #
(yy# $
objectyy$ *
senderyy+ 1
,yy1 2
KeyPressEventArgsyy3 D
eyyE F
)yyF G
{zz 	
if{{ 
({{ 
e{{ 
.{{ 
KeyChar{{ 
=={{ 
$num{{ 
){{  
{|| 
try~~ 
{ 
MySqlConnection
?? #
servidor
??$ ,
;
??, -
servidor
?? 
=
?? 
new
?? "
MySqlConnection
??# 2
(
??2 3
$str??3 ?
)??? ?
;??? ?
servidor
?? 
.
?? 
Open
?? !
(
??! "
)
??" #
;
??# $
string
?? 
query
??  
=
??! "
$str??# ?
+??? ?
codigo??? ?
+??? ?
$str??? ?
;??? ?
MySqlCommand
??  
consulta
??! )
;
??) *
consulta
?? 
=
?? 
new
?? "
MySqlCommand
??# /
(
??/ 0
query
??0 5
,
??5 6
servidor
??7 ?
)
??? @
;
??@ A
MySqlDataReader
?? #
	resultado
??$ -
=
??. /
consulta
??0 8
.
??8 9
ExecuteReader
??9 F
(
??F G
)
??G H
;
??H I
if
?? 
(
?? 
	resultado
?? !
.
??! "
HasRows
??" )
)
??) *
{
?? 
	Resultado
?? !
(
??! "
sender
??" (
,
??( )
e
??* +
,
??+ ,
$num
??, -
)
??- .
;
??. /
	resultado
?? !
.
??! "
Read
??" &
(
??& '
)
??' (
;
??( )

lb_nombreP
?? "
.
??" #
Text
??# '
=
??( )
	resultado
??* 3
.
??3 4
	GetString
??4 =
(
??= >
$num
??> ?
)
??? @
;
??@ A

lb_precioP
?? "
.
??" #
Text
??# '
=
??( )
	resultado
??* 3
.
??3 4
	GetString
??4 =
(
??= >
$num
??> ?
)
??? @
;
??@ A
	lb_stockP
?? !
.
??! "
Text
??" &
=
??' (
	resultado
??) 2
.
??2 3
	GetString
??3 <
(
??< =
$num
??= >
)
??> ?
;
??? @
lb_descP
??  
.
??  !
Text
??! %
=
??& '
	resultado
??( 1
.
??1 2
	GetString
??2 ;
(
??; <
$num
??< =
)
??= >
;
??> ?
img_producto
?? $
.
??$ %
ImageLocation
??% 2
=
??3 4
	resultado
??5 >
.
??> ?
	GetString
??? H
(
??H I
$num
??I J
)
??J K
;
??K L
img_producto
?? $
.
??$ %
SizeMode
??% -
=
??. / 
PictureBoxSizeMode
??0 B
.
??B C
StretchImage
??C O
;
??O P
}
?? 
else
?? 
{
?? 
	Resultado
?? !
(
??! "
sender
??" (
,
??( )
e
??* +
,
??+ ,
$num
??- .
)
??. /
;
??/ 0
}
?? 
segundos
?? 
=
?? 
$num
??  
;
??  !
timer1
?? 
.
?? 
Enabled
?? "
=
??# $
true
??% )
;
??) *
}
?? 
catch
?? 
(
?? 
	Exception
??  
x
??! "
)
??" #
{
?? 
	Resultado
?? 
(
?? 
sender
?? $
,
??$ %
e
??& '
,
??' (
$num
??) *
)
??* +
;
??+ ,
segundos
?? 
=
?? 
$num
??  
;
??  !
timer1
?? 
.
?? 
Enabled
?? "
=
??# $
true
??% )
;
??) *

MessageBox
?? 
.
?? 
Show
?? #
(
??# $
x
??$ %
.
??% &
ToString
??& .
(
??. /
)
??/ 0
,
??0 1
$str
??2 :
,
??: ;
MessageBoxButtons
??< M
.
??M N
OK
??N P
,
??P Q
MessageBoxIcon
??R `
.
??` a
Error
??a f
)
??f g
;
??g h
}
?? 
codigo
?? 
=
?? 
$str
?? 
;
?? 
}
?? 
else
?? 
{
?? 
codigo
?? 
+=
?? 
e
?? 
.
?? 
KeyChar
?? #
;
??# $
}
?? 
}
?? 	
private
?? 	
void
??
 
timer1_Tick
?? 
(
?? 
object
?? !
sender
??" (
,
??( )
	EventArgs
??* 3
e
??4 5
)
??5 6
{
?? 
segundos
?? 
++
?? 
;
?? 
if
?? 
(
?? 
segundos
?? 
==
?? 
$num
?? 
)
?? 
{
?? 
timer1
?? 
.
?? 
Enabled
?? 
=
??  
false
??! &
;
??& '
Inicio
?? 
(
?? 
sender
?? 
,
?? 
e
??  
)
??  !
;
??! "
lb_porfavor3
?? 
.
?? 
Visible
?? $
=
??% &
false
??' ,
;
??, -

lb_outcome
?? 
.
?? 
Visible
?? "
=
??# $
false
??% *
;
??* +
img_outcome
?? 
.
?? 
Visible
?? #
=
??$ %
false
??& +
;
??+ ,
lb_outcome_text
?? 
.
??  
Visible
??  '
=
??( )
false
??* /
;
??/ 0
}
?? 
}
?? 
}
?? 
}?? ?
bC:\Users\Benjimon41\Desktop\letsgetthisdubbbaby\Verificador_Precios\Verificador_Precios\Program.cs
	namespace 	
Verificador_Precios
 
{ 
static		 

class		 
Program		 
{

 
[ 	
	STAThread	 
] 
static 
void 
Main 
( 
) 
{ 	
Application 
. 
EnableVisualStyles *
(* +
)+ ,
;, -
Application 
. -
!SetCompatibleTextRenderingDefault 9
(9 :
false: ?
)? @
;@ A
Application 
. 
Run 
( 
new 
Form1  %
(% &
)& '
)' (
;( )
} 	
} 
} ?
rC:\Users\Benjimon41\Desktop\letsgetthisdubbbaby\Verificador_Precios\Verificador_Precios\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str .
). /
]/ 0
[		 
assembly		 	
:			 

AssemblyDescription		 
(		 
$str		 !
)		! "
]		" #
[

 
assembly

 	
:

	 
!
AssemblyConfiguration

  
(

  !
$str

! #
)

# $
]

$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str $
)$ %
]% &
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str 0
)0 1
]1 2
[ 
assembly 	
:	 

AssemblyCopyright 
( 
$str 7
)7 8
]8 9
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[ 
assembly 	
:	 

Guid 
( 
$str 6
)6 7
]7 8
[## 
assembly## 	
:##	 

AssemblyVersion## 
(## 
$str## $
)##$ %
]##% &
[$$ 
assembly$$ 	
:$$	 

AssemblyFileVersion$$ 
($$ 
$str$$ (
)$$( )
]$$) *