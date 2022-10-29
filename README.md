# A day in headspace
A platformer game made in Windows Forms App with C#.

## Table of Contents.
- [wth is this project](#the-project)
  - [Why this game](#why-platformer-and-not-something-else)
  - [My goals](#my-goals)
  - [Difficulties encountered](#difficulties-encountered)
- [Theme of the game](#theme-of-the-game)
  - [Lore](#lore)
- [How to win ?](#how-to-win)
- [All the features](#all-the-features)

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

## Theme of the game
As a huge fan of Omori, I thought of it straight away when I heard the project was 2D games.
The collectable rocks are an in game npc, a character called Kel lost his rock friend Hector. I thought it was a good idea to go look for many Hectors in my game ! It really fits the idea of Omori's headspace.
The jam is an item that revive your character, in our case I choose to make it an item capable of killing one enemy by changing it into a bread slice (just like characters in Omori hehe).

(May contain Omori spoilers) In my game, if the player fails to reach the end (falls down or touch an enemy without having jam) it will trigger Black space. In the Omori game Black space is parallel universe to White space (winning area in my game). It represents the character Sunny (the protagonist of Omori, real world counterpart of character Omori) fears ans memories. I thought it was a good idea to compare the wining area with the losing one, hence the choice of White space and Black space. The cutscenes triggered and small parts of Omori game cutscenes which represents the conflict in the mind of Sunny, which follows the change of Headspace (purple area), White space (wining area) and Black space (losing area).

### Lore
Get all of Kel rock friends to end your day and go back to your friend Mewo in White space ! But be careful, Black space is never too far away...

## How to win
To win you have to grab all the Hector (rocks) and go to the door without hitting any enemies or falling down. Once you did so, you'll reach White space, just hit the door, enjoy the last cutscene and finish the game !
If you end up falling in Black space... Sunny's repressed thoughts took over, take the key and follow your only exit, the door.

Controls :
- Space and Up => Jump
- A and Left => Go left
- D and Right => Go right

## All the features
- Menu
- Help page
- Background musics
- Grab items sounds
- Cutscenes when changing scene
- Exit button in game
- Design for every levels with differents blocks and scenery
- Moving platforms (up and down/side to side)
- Two kind of enemies (bunnies and crawler)
- Collectable items (Hector, Jam)
- Make blocks appear under certain conditions
- Lose level
- Win level

In dev :
- Two other levels between 1st in game and Win area (Sweetheart castle and The abyss)
- Make Jam collectible through all levels
- NPCs
- Longer levels
- Use of more classes in code
