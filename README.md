# challenegeZone
This is a learning zone for new C# developers

# TODO
Below are the TODO list for the next few weeks

## Create windows form application with the following controls
1. First Name label and textbox
2. Middle Name label and textbox
3. Last Name label and textbox
4. Address label and textbox.
5. Date of birth label and Date time field control
6. An Ok button and a Clear button.

# TODO Extension (With the form already created add the following)

1. Connect the form to a MongoDB database
2. Save the records into the DB
3. Ability to Update
4. Ability to Delete
5. Provide all neccesary checks during save, update and delete.

Tip: You need to create a class to Model the data that needs to be saved. It makes it easy to for the database operation.

## Actions
- When the Ok button is clicked, Print out all the information from the input boxes inside a Messagebox dialog line after the other.
- When Clear is clicked, clear all input controls and set focus to the First Name textbox.

NB: Please use proper naming conventions for your variables and controls. You can read on C# naming conventions for deeper insight.



## Submission (In a week)

1. In the first forked repository
2. Create a new folder with your **GitHub ID** + **Task3** and put your solution inside
3. Create a pull request after you have pushed your code your the forked branched
4. No need to attached a database. 


## Results

1. I will check after a pull request has been made
2. You will be notified once the grade given
3. Happy coding!!!


## Submission contains
1. Code
2. Database Script for collection
   a.  show databases
   b.  use task3_db
   b.  db.Task3.insert([{fname:'Royal' ,
                      mname:'Kennedy' ,
                      lname:'Mascer' ,
                      Add1:'F.0.6' ,
                      Add2:'PeterHelliweg',
                      DOB:'01-01-1990' ,
                      City:'Paderborn' ,
                      State:'NRW' ,
                      Country:'Germany'},
                      ])
