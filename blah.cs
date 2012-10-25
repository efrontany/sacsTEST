void main(void){

	// This is a Sample Program
	string blah = "Sample";
	
	
	printf("Booh {0}", blah);
	printThis();
	printThat();
	
	printThis(); // Again
	printThat(); // And Again
	
	return 0;
}

string printThis(void){
	printf("This");
}

string printThat(void){
	printf("That Master");
}