/*Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
void StampaArrayInteri(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”.
Potete prendere quella fatta in classe questa mattina
int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.
Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
Stampare l’array di numeri fornito a video
Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
Stampare la somma di tutti i numeri
Stampare la somma di tutti i numeri elevati al quadrati*/

//Variable here----------------------------------------------------------
int numeroUtente = 12;
int[] arrayNumeri = { 2, 6, 7, 5, 3, 9 };
Console.Write("Stampa a video dell array: ");
StampaArrayInteri(arrayNumeri);
Console.Write("Numero singolo: ");
Console.WriteLine(numeroUtente);
Console.Write("Numero singolo elevato al quadrato: ");
Console.WriteLine(ToSquare(numeroUtente));
Console.Write("Array di numeri elevato al quadrato: ");
StampaArrayInteri(ArrayToSquare(arrayNumeri));
Console.Write("Vecchio array di numeri: ");
StampaArrayInteri(arrayNumeri);
Console.Write("Somma dei numeri nell array: ");
Console.WriteLine(Summ(arrayNumeri));
Console.Write("Somma dei numeri nell array elevati al quadrato: ");
Console.WriteLine(Summ(ArrayToSquare(arrayNumeri)));
//All function here-----------------------------------------------------

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
    foreach(int numero in arrayDaSommare){
        somma += numero;
    }
    return somma;
}