# Bowling-Kata-OO
Bowling Kata - C# version using more OO principles than the usual solution

The aim of the Kata is to use Test Driven Development to build the functionality required for the game.

Usually this ends up with a very procedural implementation when you dive straight into it but for this version I took some time to think about some of the SOLID principles so that different behaviours were split into different classes!

For those that don't know how to score tenpin bowling here are the rules of scoring:
The game consists of 10 frames.  In each frame the player has
two opportunities to knock down 10 pins.  The score for the frame is the total
number of pins knocked down, plus bonuses for strikes and spares.

A spare is when the player knocks down all 10 pins in two tries.  The bonus for
that frame is the number of pins knocked down by the next roll.  So in frame 3
above, the score is 10 (the total number knocked down) plus a bonus of 5 (the
number of pins knocked down on the next roll.)

A strike is when the player knocks down all 10 pins on his first try.  The bonus
for that frame is the value of the next two balls rolled.

In the tenth frame a player who rolls a spare or strike is allowed to roll the extra
balls to complete the frame.  However no more than three balls can be rolled in
tenth frame.
