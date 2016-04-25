#include <stdlib.h>
#include <stdio.h>
#include <string.h>

void echanger(int tableau[], int a, int b)
{
    int temp = tableau[a];
    tableau[a] = tableau[b];
    tableau[b] = temp;
}

void quickSort(int tableau[], int debut, int fin)
{
    int gauche = debut-1;
    int droite = fin+1;
    const int pivot = tableau[debut];

    /* Si le tableau est de longueur nulle, il n'y a rien à faire. */
    if(debut >= fin)
        return;

    /* Sinon, on parcourt le tableau, une fois de droite à gauche, et une
       autre de gauche à droite, à la recherche d'éléments mal placés,
       que l'on permute. Si les deux parcours se croisent, on arrête. */
    while(1)
    {
        do droite--; while(tableau[droite] > pivot);
        do gauche++; while(tableau[gauche] < pivot);

        if(gauche < droite)
            echanger(tableau, gauche, droite);
        else break;
    }

    /* Maintenant, tous les éléments inférieurs au pivot sont avant ceux
       supérieurs au pivot. On a donc deux groupes de cases à trier. On utilise
       pour cela... la méthode quickSort elle-même ! */
    quickSort(tableau, debut, droite);
    quickSort(tableau, droite+1, fin);
}

int main()
{
    int N;
    scanf("%d", &N);
    
    int *tab;
    tab = (int *)calloc(N, sizeof(int));
    
    for (int i = 0; i < N; i++) {
        scanf("%d", &tab[i]);
    }
    
    
    /*for (int i = 0; i < N; i++) {
        for (int x = i+1; x < N; x++) {
            if(tab[i] > tab[x]) {
                int tmp = tab[x];
                tab[x] = tab[i];
                tab[i] = tmp;
            }
        }
    }*/
    fprintf(stderr, "%d\n", N);
    if(N > 10000) {
        quickSort(tab, 0, 10000);
    } else {
        quickSort(tab, 0, N);
    }
    
    for (int i = 0; i < N; i++) {
        //fprintf(stderr, "%d ", tab[i]);
    }
    fprintf(stderr, "\n");
    
    int min = tab[1] - tab[0];
    
    for (int i = 0; i < N; i++) {
        int tmp;
        
        if(tab[i+1] - tab[i] < 0) {
            tmp = tab[i+1] - tab[i] * -1;
        } else {
            tmp = tab[i+1] - tab[i];
        }
        
        if(tmp < min && i < N) {
            min = tmp;
            fprintf(stderr, "min : %d\n", min);
        }
    }
        
    printf("%d", min);

}