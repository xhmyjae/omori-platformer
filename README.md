# A day in headspace
A platformer game made in Windows Forms App with C#.

## Table of Contents.
- [wth is this project](#the-project)
  - [Why this game](#why-platformer-and-not-something-else)
  - [My goals](#my-goals)
  - [Difficulties encountered](#difficulties-encountered)
- [Theme of the game](#theme)
  - [Lore](#lore)
- [How to win ?](#gameplay)
- [All the current features](#features)

------

## The project
A day in headspace is a very simple platformer game made with Windows Forms App in C#.
WFA is outdated and sucks, but it was for a school project.. So it's fine right ? :') 

### Why platformer and not something else
We didn't have much of a choice. We were able to pick one out of all the other exciting mini-games (like Snake, Pong or Space invaders). Random.org told me to do the platformer, I complied.
Tbh it's pretty fun so I like it, and I'm having lot of fun coding it, especially with this transparency.. yumyum.

### My goals
When making this game I had two things in mind : get a good grade and overwork myself till I stress out when I don't have any time left (???)
Let's stop joking around, professor gonna read all of that...
My first main goal was to make a game with a theme I liked, hence why I choose Omori. Make the player get a glimpse of the game universe was a major point. Then I had to make the game playable, which means :
    - imagine and make the platforms collisions (since WFA is not made for games they are not implemented)
    - make player move and jump
    - make enemies more or less hard
    - add small boost
For me, the goals were to improve my knowledge in C#, discover WFA (I used them in the past, you might find some repositories on my profile), handle a limited amount of time, structure all my plans. I managed to do all I was planning on and am now working on bonus stuff. So I can say I reached my goals.

### Difficulties encountered
The main issues with the project might be pretty obvious, it was the use of WFA. Since it's not made for game development all the usual basic options (collisions, gravity, shapes, shadows, ...) were not available. So we had to make all the methods oursleves.
The time limit was also an issue, but only because I wanted to do "more" than the instructions said (like make more levels, add special features as moving blocks, add design to the game).
I also had some difficulties using timers through classes since the System Timers and Forms Timers are not the same (I manage to fix it).
Tho, the issue that took me the longest to fix was the video implementation. I tried to use gif with a timer, video with WMP library, ... in the end I went for the images changing every x milliseconds. Which actually ends up looking better since it goes with the omori vibe better.

