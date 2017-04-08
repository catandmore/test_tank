#include <stdio.h>

int main(){
	int t;scanf("%d",&t);
	while(t--){
		int s[4][4];int i,j;
		for(i=0;i<4;i++){
			for(j=0;j<4;j++){
				scanf("%d",&s[i][j]);
			}
		}
		int q;scanf("%d",&q);
		while(q--){
			int choice;scanf("%d",&choice); //1:ÉÏ 2£ºÏÂ 3£º×ó  4 £ºÓÒ
			 if(choice == 1){
			 	for (i=1;i<4;i++){
			 		for (j=0;j<4;j++){
			 			if(s[i-1][j]==0){
			 				s[i-1][j]=s[i][j];
			 				s[i][j]=0;
						 }
						 if(s[i-1][j]==s[i][j]){
						 	s[i-1][j]=2*s[i][j];
						 	s[i][j]=0;
						 }
					 }
				 }
			 }
			 else if(choice == 2){
			 	for(i=2;i>=0;i--){
			 		for(j=0;j<4;j++){
			 			if(s[i+1][j]==0){
			 				s[i+1][j]=s[i][j];
			 				s[i][j]=0;
						 }
						 if(s[i+1][j]==s[i][j]){
						 	s[i+1][j]=2*s[i][j];
						 	s[i][j]=0;
						 }
					 }
				 }
			 }
			 else if(choice == 3){
			 	for(j =1;j<4;j++){
			 		for(i=0;i<4;i++){
			 			if(s[i][j-1]==0){
			 				s[i][j-1]=s[i][j];
			 				s[i][j]=0;
						 }
						 if(s[i][j-1]==s[i][j]){
						 	s[i][j-1]=2*s[i][j];
						 	s[i][j]=0;
						 }
					 }
				 }
			 }
			 else if(choice ==4){
			 	for(j=2;j>=0;j--){
			 		for(i=0;i<4;i++){
			 			if(s[i][j+1]==0){
			 				s[i][j+1]=s[i][j];
			 				s[i][j]=0;
						 }
						 if(s[i][j+1]==s[i][j]){
						 	s[i][j+1]=2*s[i][j];
						 	s[i][j]=0;
						 }
					 }
				 }	
			 }
			 for (i =0;i<4;i++){
			 	for(j=0;j<4;j++){
			 		printf("%5d",s[i][j]);
				 }
				 printf("\n");
			 } 
		}
		printf("\n");
	} 
}

