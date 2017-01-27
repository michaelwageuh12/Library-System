#include<iostream>
using namespace std;
class page{
	string content;
	int page_num;
public:
	page(){
		content = " ";
		page_num = 0;
	}

	page(string c,int n){
		content = c;
		page_num = n;
	}

	void set_page_num(int a){
		page_num = a;
	}

	string show(){
		return content;
	}

	~page(){

	}
};

class book{
	string title;
	int ID;
	page pages[100];
	string writer;

public:
	book(){
		title = " ";
		ID = 0;
		writer = " ";
		for (int i = 1; i <= 100; i++)
			pages[i].set_page_num(i);
	}

	book(string t, int i, string w, page *p=NULL){
		title = t;
		ID = i;
		writer = w;
		if (p == NULL)
			for (int i = 0; i < 100; i++)
				pages[i].set_page_num(i + 1);
			else
			for (int i = 0; i < 100; i++)
				pages[i] = p[i];

	}

};

class container{
	string category;
	book *books;

public:
	container(){
		category = " ";
		books = NULL;
	}

	container(string s, book *q){
		category = s;
		books = q;

	}

	void set_book(book* b){
		books = b;
	}

};




int main(){
	int size;
	cin >> size;
	book *s=new book[size];
	string m = "math";
	container c(m, s);
	book books_1;
	c.set_book(&books_1);

	return 0;
}