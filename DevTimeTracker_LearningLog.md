

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
