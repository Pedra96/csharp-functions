/*BONUS:
Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile, 
ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via. 
A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente.
Rieseguire il programma con l’input preso esternamente dall’utente.*/



//Variable here----------------------------------------------------------

int[] arrayNumeri ={};

arrayUtente();
Wait();
Console.Write("Stampa a video dell array: ");
StampaArrayInteri(arrayNumeri);
Console.Write("Array di numeri elevato al quadrato: ");
StampaArrayInteri(ArrayToSquare(arrayNumeri));
Console.Write("Vecchio array di numeri: ");
StampaArrayInteri(arrayNumeri);
Console.Write("Somma dei numeri nell array: ");
Console.WriteLine(Summ(arrayNumeri));
Console.Write("Somma dei numeri nell array elevati al quadrato: ");
Console.WriteLine(ToSquare(Summ(arrayNumeri)));

//All function here-----------------------------------------------------

int[] arrayUtente() {
    Console.WriteLine("Quanto lungo lo vuoi l'array?");
    int index = Convert.ToInt32(Console.ReadLine());
    int input;
     arrayNumeri = new int[index];
    for(int i=0;i<arrayNumeri.Length;i++) {
        Console.WriteLine("inserisci un numero");
        input = Convert.ToInt32(Console.ReadLine());
        arrayNumeri[i] = input;
    }
    return arrayNumeri;
}




void StampaArrayInteri(int[] arrayInteri) {

    string numeriInteri = "[";

    for (int i = 0; i < arrayInteri.Length; i++) {
        if (i == arrayNumeri.Length - 1) {
            numeriInteri += arrayInteri[i];
        } else {
            numeriInteri += arrayInteri[i] + ",";
        }
    }

    numeriInteri += "]";
    Console.WriteLine(numeriInteri);
}

int ToSquare(int n) {
    return n * n;
}

int[] ArrayToSquare(int[] arrayNum) {
    int[] copiaArray = (int[])arrayNum.Clone();
    for (int i = 0; i < arrayNum.Length; i++) {
        copiaArray[i] = ToSquare(copiaArray[i]);
    }
    return copiaArray;
}

int Summ(int[] arrayDaSommare) {
    int somma = 0;
    foreach (int numero in arrayDaSommare) {
        somma += numero;
    }
    return somma;
}

void Wait() {
    string evilplan = "Calcolo dell'array è bello pesante ci vorrà un po'... attendere...";
    for (int i = 0; i < evilplan.Length; i++) {
        if (i == evilplan.Length - 1) {
            Console.WriteLine(evilplan[i]);
            Thread.Sleep(500);
        } else {
            Console.Write(evilplan[i]);
            Thread.Sleep(500);
        }
    }
}