// See https://aka.ms/new-console-template for more information
Console.Write("Geben Sie Ihren Namen ein: ");
string strName = Console.ReadLine();

string strFrage = "Warum ist Python so berühmt?";
string strAntwort1 = "Antwortmöglichkeit 1: Pythons Syntax ähnelt der englischen Sprache, deshalb ist die Programmiersprache auch für Coding-Neulinge relativ einfach zu lernen";
string strAntwort2 = "Antwortmöglichkeit 2: Weil man damit Spiele programmieren kann";
string strAntwort3 = "Antwortmöglichkeit 3: Weil es gehypt ist";
string strAntwort4 = "Antwortmöglichkeit 4: Weil es sehr leicht ist";

Console.WriteLine(strFrage);
Console.WriteLine(strAntwort1);
Console.WriteLine(strAntwort2);
Console.WriteLine(strAntwort3);
Console.WriteLine(strAntwort4);
Console.Write("Geben Sie die Zahl der Antwortmöglichkeit ein!: ");
string sErsteFrage = Console.ReadLine();
bool trueFalse1 = false;
if (sErsteFrage == "1")
{
    Console.WriteLine("Richtig");
    trueFalse1 = true;
}
else
{
    Console.WriteLine("Falsch");
}

string Frage = "Welche For-Schleife entspricht ";
string Antwort1 = "Antwortmöglichkeit 1: forif 2 in range(2)";
string Antwort2 = "Antwortmöglichkeit 2: for item in MyArray()";
string Antwort3 = "Antwortmöglichkeit 3: for i in range(1, 7)";
string Antwort4 = "Antwortmöglichkeit 4: for i<4()";

Console.WriteLine(Frage);
Console.WriteLine(Antwort1);
Console.WriteLine(Antwort2);
Console.WriteLine(Antwort3);
Console.WriteLine(Antwort4);
Console.Write("Geben Sie die Zahl der Antwortmöglichkeit ein!: ");
string sZweiteFrage = Console.ReadLine();
bool truefalse2 = false;
if(sZweiteFrage =="3")
{
    Console.WriteLine("Richtig");
    truefalse2 = true;
}
else
{
    Console.WriteLine("Falsch");
}

System.IO.StreamWriter sw = new StreamWriter("antworten_" + strName + ".txt");
sw.WriteLine("Benutzer: " + strName);
sw.WriteLine(strFrage);
sw.WriteLine(strAntwort1);
sw.WriteLine(strAntwort2);
sw.WriteLine(strAntwort3);
sw.WriteLine(strAntwort4);
if(trueFalse1 = true)
{
    sw.WriteLine("Frage wurde richtig beantwortet");
}
else
{
    sw.WriteLine("Frage wurde falsch beantwortet");
}
sw.WriteLine("-------");
sw.WriteLine(Frage);
sw.WriteLine(Antwort1);
sw.WriteLine(Antwort2);
sw.WriteLine(Antwort3);
sw.WriteLine(Antwort4);
if (truefalse2 = true)
{
    sw.WriteLine("Frage wurde richtig beantwortet");
}
else
{
    sw.WriteLine("Frage wurde falsch beantwortet");
}
sw.Close();