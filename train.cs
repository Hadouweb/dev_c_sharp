#include <stdlib.h>
#include <stdio.h>
#include <string.h>

static int N;

typedef struct  s_data
{
    int         id;
    char        *name;
    float       lon;
    float       lat;
}               data;

int     ft_strlen(char *str)
{
    int     i;
    
    i = 0;
    while (str[i] && str[i] != ';')
        i++;
    return (i);
}

void    ft_strcpy(char *n, char *o)
{
    int     i;
    
    i = 0;
    //printf("%s\n", o);
    while (o[i] && o[i] != ';')
    {
        n[i] = o[i];
        i++;
    }
    n[i] = '\0';
}

char    *float_format(char *str)
{
    int     i;
    
    i = 0;
    while (str[i])
    {
        if (str[i] == ',')
            str[i] = '.';
        i++;
    }
    return (str);
}

char    **split(char *str)
{
    char    **data;
    int     i;
    int     j;
    
    j = 0;
    data = (char **)malloc(sizeof(data) * 6);
    data[j] = (char *)malloc(ft_strlen(str));
    ft_strcpy(data[j], str);
    j++;
    i = ft_strlen(str);
    while (str[i])
    {
        if (str[i] == ';')
        {
            if (str[i + 1] == ';')
            {
                data[j] = (char *)malloc(5);
                data[j] = "null";
            }
            else
            {
                data[j] = (char *)malloc(ft_strlen(&str[i + 1]) + 1);
                ft_strcpy(data[j], &str[i + 1]);
            }
            j++;
        }
        i++;
    }
    return (data);
}

data    save_data(char *str)
{
    data    n;
    int     i;
    int     j;
    char    **data;
    
    i = 0;
    j = 0;
    data = split(str);
    n.id = atoi(data[0]);
    n.name = data[1];
    n.lon = atof(float_format(data[4]));
    n.lat = atof(float_format(data[5]));
    j++;
    return (n);
}

char    *search(data *d, float lon, float lat)
{
    int     i;
    float   dist;
    float   tmp;
    float   x;
    float   y;
    char    *name;
    
    i = 0;
    dist = -1.0;
    while (i < N)
    {
        x = (d[i].lon - lon) * cos((lat + d[i].lat)/2);
        y = (d[i].lat - lat);
        tmp = sqrt((x * x) + (y * y)) * 6371;
        if (dist == -1.0)
        {
            dist = tmp;
            name = d[i].name;
        }
        else if (tmp < dist)
        {
            dist = tmp;
            name = d[i].name;
        }
        i++;
    }
    return (name);
}

int     main()
{
    char    LON[50];
    char    LAT[50];  
    char    DEFIB[256];
    
    scanf("%s", LON); fgetc(stdin);
    scanf("%s", LAT); fgetc(stdin);
    scanf("%d", &N); fgetc(stdin);
    data d[N];
    for (int i = 0; i < N; i++) {
        fgets(DEFIB,256,stdin);
        d[i] = save_data(DEFIB);
    }

    printf("%s", search(d, atof(float_format(LON)), atof(float_format(LAT))));
    
    return 0;
}