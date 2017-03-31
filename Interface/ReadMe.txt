STILL IN BETA. :)

This version contains: 

Title (String) 
AgeRate (String) 
Duration (String) 
Genre (List<string>) 
Release Year (String) 
Description (String) 
Director (String) 
Star Rate (String) 

After installing call the .dll file. 

using using imdbAPI; 

Create instance of class: 
imdb test = new imdb("tt1964418"); 

where 'tt1964418' is the movie id on IMDB link (http://www.imdb.com/title/tt1964418/) 

label1.text = test.imdbTitle(); 

______________________________________________________ 

AND as for Genre it return a string. 

This is the sample: 

imdb im = new imdb("tt1964418"); 

for (int i = 0; i < im.imdbGenre().Count; i++) 
{ 
    label1.Text += im.imdbGenre()[i] + "\n"; 
} 

NOTE: When this class return the genre it will take some time, so be patient. 

Thank you. :)