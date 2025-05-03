

# DevTimeTracker Question Log

---
## [Date: 2025-04-28]

**Question 1:**  


**What I Tried:**  


**Answer I Found:**  


**Next Action:**  

---

## [Date: 2025-04-28]

**Question 1:**  
how to build the project?

**What I Tried:**  
i was thinking of a class library and a concole app to interact with the user

**Answer I Found:**  
yes, i did that 

**Next Action:**  
i will build session.cs tommorrow and see after that

---

## [Date: 2025-04-29]

*Question 1:*
properties for session.cs ??

*What I Tried:*
i am thinking that StartTime, EndTime, SessionType

*Answer I Found:*  
added to them the projectName property and description

*Next Action:*
make the session class and then start to write the ISessionStore (where sessions will be stored)

---

## [Date: 2025-05-1]

*Question 1:*
what is the difference between DateTime and DateOnly??

*What I Tried:*
i think that DateOnly is shorter than DateTime but what i am really asking about is when to use what

*Answer I Found:*  
Date time includes time and Date like 1-5-2025 5:01 
DateOnly stores only date like 1-5-2025
best to stick with DateTime for now i need the time for calculating durations and stuff

*Next Action:*
the SessionType enum problem

---

*Question 2:*
Can the user add more labels in sessionType enum or not?I'm good with adding an "Other" label for other suggestions but making it custom would be cool

*What I Tried:*
i always prefer customizing but not gonna deny , it adds complexity 

*Answer I Found:*  
when i had a discussion with chatgpt,i chose to go with adding "Other" label because making it custom will turn the enum to list and it will add more 
things like ensuring there is no duplicates, no typos, and i am thinking now that it will cause problems with scalability in the future because the 
list will go ai=out of hand other than the effort of adding, updating,... the list :(
I WILL STICK WITH ADDING -OTHER- LABEL TO THE ENUM AND IT REDUCES DISTRACTION FOR PERFICTIONISTS IF YOU ASKED ME (Guaranteed hack!)

*Next Action:*
i will start designing the sessionStore class(wish yourself luck) 

---

**Question 3:**  
why is this code:
public SessionStore(List<Session> _sessions){
   Sessions = _sessions;
}
violates encapsulation?

**What I Tried:**  
i think because of accessibility and security

**Answer I Found:**  
actually yeah, why would i allow external caller to add list of sessions while i am making the list private to make the dealing with it through methods only>>
bad design to be honest  
i know it is easy question but it is a trap i fall into which means it deserves to be written in the learning log

**Next Action:**  
well, implement the add, remove,... methods

---

## [Date: 2025-05-2]
^^ today i will finish the session manager ^^
##################################################################################
SessionManager Layer (Logic Layer)

This is the brain of the app. It talks to SessionStore and handles:

Creating a new session (with user input or mocked)

Ending a session

Listing sessions with filters or sorting

Summarizing stats

⏳ Estimated Time: 1–2 days (because it connects everything and might need small refactoring as you test)

#################################################################################


*Question 1:*
in removeSession method, with which attribute will i search if such a session exists?

*What I Tried:*
unique attribute is startTime but how could a user know it???

*Answer I Found:*  


*Next Action:*


---
*Question 2:*
whose responsibility is validation and why?? is it the sessionManager or the console app?

*What I Tried:*
i think the session manager is responsible as the backend part(simulation)

*Answer I Found:*  


*Next Action:*

---

*Question 3:*
how can manage starting and ending a session?

*What I Tried:*
i think of a shared session

*Answer I Found:*  
yes currentSession is shared and i don't add it to the sessionStore unitl endSession method is called
don't forget to make it null

*Next Action:*
i want to make a method that is visually good to be like the window for the use to see which session he is in right now(anyone can forget something even if he did it, even genius ones!!)
also seeing progress is a good thing

---

*Question 4:*
should i keep project names in  list so that i can do operations like preventing duplicates or something??

*What I Tried:*


*Answer I Found:*  


*Next Action:*

---
## [Date: 2025-05-3]

*Question 1:*
i was confused here because the right return type was session but what if i don't have a current one???

*What I Tried:*
i will let the user(console app) manages null checking

*Answer I Found:*  
i returned session? and let the null checking to the user because i am trying too stock to the rule: formatting is the front's responsibility. 

*Next Action:*
i will read about serialization and deserialization and how can i use them effectively in my project

next time you get stuck with the same problem: 

ASK YOURSELF:
What is the type of data I want to return? Will that type always be consistent?”

If the answer is “sometimes I return A, sometimes B,” that’s a signal you either:

Need a consistent return type (e.g. always Session?)

Or need to separate behavior: one method returns data, another handles output.

---
