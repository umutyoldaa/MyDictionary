// See https://aka.ms/new-console-template for more information
using MyDictionary;



//Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

AddValue<int, string> keyValuePairs = new AddValue<int, string>();

keyValuePairs.Add(1, "JANUARY");
keyValuePairs.Add(2, "FEBRUARY");
keyValuePairs.Add(3, "MARCH");
keyValuePairs.Add(4, "APRIL");

//list fonksiyonu ile degerlerin eklendigini gorebilirsin.
keyValuePairs.List();
