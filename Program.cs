// See https://aka.ms/new-console-template for more information

// Matematiksel Operatörler : 
//(+,-,*,/,%)

// değişkenleri kullanarak, toplama çıkartma çarpma bölme ve mod alma işlemi yapalım

int birinciSayi = 67;
int ikinciSayi =38;
int toplam,carpim,bolum,mod,cikartim=0;

toplam=birinciSayi+ikinciSayi;
cikartim=birinciSayi-ikinciSayi;
carpim=birinciSayi*ikinciSayi;
bolum=birinciSayi/ikinciSayi;
mod=birinciSayi%ikinciSayi;

// işlemler tamamlandı : 

// Sonuçları ekrana yazdıralım
Console.WriteLine(toplam);
Console.WriteLine("Çıkartım :"+cikartim);
Console.WriteLine("{0}+{1}={2}",birinciSayi,ikinciSayi,toplam);
Console.WriteLine("{0}-{1}={2}",birinciSayi,ikinciSayi,cikartim);
Console.WriteLine("{0}/{1}={2}",birinciSayi,ikinciSayi,bolum);
Console.WriteLine("{0}*{1}={2}",birinciSayi,ikinciSayi,carpim);
Console.WriteLine("{0}%{1}={2}",birinciSayi,ikinciSayi,mod);


// Mantıksal Operatörler : 
//(>,<,<=,>=,,==,!=))(&&,||)
// mantıksal operatörlerden geriye her zaman true yada false değer döner,  bu değerleri karşılamak için, 
// bool tipinde bir değişken tanımlamalı ve bu operatörlerden gelen değeri, bool tipi üzerinde tutmalısınız.


int buyukSayi = 100;
int kucukSayi = 8;


bool kucukmu=kucukSayi<buyukSayi;
bool buyukmu = kucukSayi>buyukSayi;
bool esitmi = kucukSayi==buyukSayi;
bool esitDegilmi = kucukSayi!=buyukSayi;
Console.WriteLine("{0} küçük mü {1}'den: {2}",kucukSayi,buyukSayi,kucukmu);
Console.WriteLine("{0} büyük mü {1}'den : {2}",kucukSayi,buyukSayi,buyukmu);
Console.WriteLine("{0} esitmi {1}'e :{2}",kucukSayi,buyukSayi,esitmi);
Console.WriteLine("{0} esit değil mi {1}'e: {2}",kucukSayi,buyukSayi,esitDegilmi);

// ve, veya operatörü : 
string kullanicidanGelenUserName,kullanicidanGelenPassword,veriTabanindakiUserName,veriTabanindakiPassword;

veriTabanindakiPassword="2020";
veriTabanindakiUserName="root";

// kullanıcıdan gelenleri değişkene atayalım
kullanicidanGelenUserName="wissen";
kullanicidanGelenPassword="2020";

// mantıksal operatörlerden bool değer döner.

bool girisIsOk = kullanicidanGelenUserName==veriTabanindakiUserName && kullanicidanGelenPassword==veriTabanindakiPassword;


// true && false = her zaman false verir
// true && true = true
// false && true=false
// false && false = false

Console.WriteLine("And Operatörü Giriş okey mi  : "+girisIsOk);




bool girisOrOk= kullanicidanGelenUserName==veriTabanindakiUserName || kullanicidanGelenPassword==veriTabanindakiPassword;
// or operatöründe, tek şartın true olması, sonucu true döndürür

Console.WriteLine("Or Operatörü giriş okey mi :"+girisOrOk);

int sayi1=4;
int sayi2=5;
int sayi3=6;
int sayi4=1;
int sayi5=45;
int sayi6=22;
int sayi7=99;

bool result =   (sayi4<sayi1 ||sayi7!=sayi3) || (sayi1!=sayi7 && sayi2==sayi4) ;
Console.WriteLine(result);

// Ve , Veya operatörlerinde, işlem önceliği için parantezin önemi büyük ..

// Atama operatörleri : 

// bir değişken tanımlayıp, bu değişkene bir değer verelim, ve bu değeri 1 artıralım

int degisken = 10;
degisken=degisken+1;
Console.WriteLine(degisken);
// yukarıdaki yöntem çalışssa da, pratik değil

// bunun için,  operatörlerden faydalanabiliriz.


degisken+=1;
Console.WriteLine(degisken);  

// bunu iki değişken ile yapalım, yani bir değişkenin değerini, diğer değişken kadar artıralım
/*
int birinciDegisken =10;
int ikinciDegisken = 80;
birinciDegisken+=ikinciDegisken;
Console.WriteLine(birinciDegisken);
*/
// aynı denemeyi çarpı ile deneyelim 
/*
int birinciDegisken  = 10;
birinciDegisken*=5;
Console.WriteLine(birinciDegisken);
*/


// aynı denemeyi - ile yapalım

/*
int birinciDegisken = 10;
birinciDegisken-=5;
Console.WriteLine(birinciDegisken);
*/
// aynı denemeyi / ile yapalım
/*
int birinciDegisken = 10;
birinciDegisken/=5;
Console.WriteLine(birinciDegisken);
*/

// Atama Operatörleri : 
// (++,--,**, vb)
// tekrar hatırlayalım, değişkenin değerini artırmak için, hangi yöntemler var, 

//1. yöntem
//int deger =10;
//int sonuc = deger+1;


// 2 . yöntem
//int deger = 10;
//deger+=1;


// 3. yöntem
/*int deger = 0;
deger++;
Console.WriteLine(deger);

// azaltalım
deger--;
Console.WriteLine(deger);
*/
// değeri hızlıca bir artımak yada bir eksilmek için yukarıdaki yöntem kullanılır.

// ++ operatörü degiskenin sonunda yada başında olduğunda ne değişir.


// ++ operaötür, sağda ise, önce atama, sonra artırma yapılır
/*int deger = 0;
int sonuc = deger++;
Console.WriteLine(sonuc);
*/


// ++ operatörü, solda ise, önce artırma, sonra atama yapılır.
int deger = 0;
int sonuc = ++deger;
Console.WriteLine(sonuc);


