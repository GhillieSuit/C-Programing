#include <stdio.h>
#define fourth
#define MAX 2

#ifdef fourth
typedef struct student
{
	char* name;
	char* number;
	int mid;
	int fin;
}STUDENT;
#endif // fourth

int main()
{
#ifdef first
	int mid, fin, avg;
	char name[10];
	char number[10];

	strcpy(name, "User");
	strcpy(number, "201544058");
	mid = 50;
	fin = 70;

	avg = (mid + fin) / 2;

	printf("%s(%s) : 중간 %d, 기말 %d, 평균 %d\n", name, number, mid, fin, avg);
#endif // first

#ifdef second
	int mid, fin, avg;
	char name[10];
	char number[10];

	int mid2, fin2, avg2;
	char name2[10];
	char number2[10];

	strcpy(name, "User1");
	strcpy(number, "201544058");
	mid = 50;
	fin = 70;

	strcpy(name2, "User2");
	strcpy(number2, "201544051");
	mid2 = 40;
	fin2 = 50;

	avg = (mid + fin) / 2;
	avg2 = (mid2 + fin2) / 2;

	printf("%s(%s) : 중간 %d, 기말 %d, 평균 %d\n", name, number, mid, fin, avg);
	printf("%s(%s) : 중간 %d, 기말 %d, 평균 %d\n", name2, number2, mid2, fin2, avg2);

#endif // second

#ifdef third
	int i;
	int mid[MAX], fin[MAX], avg[MAX];
	char* name[MAX];
	char* number[MAX];

	name[0] = "User1";
	number[0] = "201544058";
	mid[0] = 50;
	fin[0] = 70;

	name[1] = "User2";
	number[1] = "201544051";
	mid[1] = 40;
	fin[1] = 50;

	for (i = 0; i < MAX; i++)
	{
		avg[i] = (mid[i] + fin[i]) / 2;

		printf("%s(%s) : 중간 %d, 기말 %d, 평균 %d\n", name[i], number[i], mid[i], fin[i], avg[i]);
	}
#endif // third

#ifdef fourth
	int i;
	STUDENT stulist[MAX];

	stulist[0].name = "User1";
	stulist[0].number = "201544058";
	stulist[0].mid = "50";
	stulist[0].fin = "70";

	stulist[1].name = "User2";
	stulist[1].number = "201544051";
	stulist[1].mid = "40";
	stulist[1].fin = "50";

	for (i = 0; i < MAX; i++)
	{
		printf("%s(%s) : 중간 %d, 기말 %d, 평균%d\n",
			stulist[i].name, stulist[i].number,
			stulist[i].mid, stulist[i].fin,
			(stulist[i].mid + stulist[i].fin) / 2);
	}
#endif // fourth

	return 0;
}