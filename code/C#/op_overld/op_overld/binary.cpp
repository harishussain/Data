#include<iostream>
#include<stdio.h>
#include<conio.h>

using namespace std;

class Distance

{
public: int feet;
		 float inches;
public:
		 Distance():feet(0),inches(0.0)
		 {}
			 Distance(int ft,float in):feet(ft),inches(in)
			 {}
			 void getdist()
			 {
				 cout<<"enter feet";
				 cin>>feet;
				 cout<<"enter inches";
				 cin>>inches;
			 }
				 void showdist()
				 {
					 cout<<feet<<"/"<<inches<<endl;
				
				 }
				Distance operator-(Distance) const ;
				 };
			

			Distance Distance::operator -(Distance d2) const
    
			
			{
				int f=feet-d2.feet;
				float i=inches-d2.inches;
				return Distance(f,i);
			}
			void main(void)
			{
				Distance dist1,dist3;
				dist1.getdist();
				Distance dist2(10,5.5);
				dist3= dist1-dist2;
				cout<<"dist1="; dist1.showdist(); cout<<endl;
				cout<<"dist2="; dist2.showdist(); cout<<endl;
				cout<<"dist3="; dist3.showdist(); cout<<endl;
				getch();

			}

			





	


