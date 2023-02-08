using GenericExtraStudy;

NamedContainer<int> namedContainer= new NamedContainer<int>();

namedContainer.Value = 1;
var anotherNamedContainer = namedContainer.ExampleMethodOfUType<NamedContainer<double>>();
anotherNamedContainer.Value = 2.0;
anotherNamedContainer.Name= "A Name that tells this is a double Named Container";

var thisIsAPersonObject = anotherNamedContainer.ExampleMethodOfUType<Person>();
thisIsAPersonObject.FirstName =  "A";
thisIsAPersonObject.LastName = "B";



NamedContainer<string> namedContainer1= new NamedContainer<string>();

namedContainer1.Value = "A String";

NamedContainer<Enum> namedContainer2= new NamedContainer<Enum>();
namedContainer2.Value = Color.Blue;

