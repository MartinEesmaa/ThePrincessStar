# The Princess Star (deprecated & archived)

***NOTE: This game is no longer development anymore.***

# Screenshot:
![princessstarunity](https://user-images.githubusercontent.com/88035011/196579623-7c471b08-f19e-4807-ad86-0573383e8515.png)

# Build

Before you build this game, you need Git with LFS and Unity Hub with your Unity account & any version (example latest LTS version).

For Windows: [Download link](https://git-scm.com/download/win).

For macOS: `brew install git-lfs`. You need [Homebrew](https://brew.sh/).

For Linux: `sudo apt install git-lfs`. 

For Fedora, replace apt with dnf. Other OS will install git-lfs by a default package manager.

1: Clone with LFS support:
```
git lfs clone --depth=1 https://github.com/MartinEesmaa/ThePrincessStar
```

2: Click "Open project" in Unity Hub, select my game and it will automatically open the project, when it's first time.

This could take about couple minutes for loading project for first time. After first time open, it's ready to run faster, when opening project again.

3: Once Unity Engine opens up, go to File -> Build & Run or Build Settings. Select any folders or create folder to compile the game.

For additional compression, go to Build Settings and select compression method for LZ4HC.

4: Enjoy and run the game :).

### Learned and took sample codes:

https://github.com/codinginflow/2DPlatformerBeginner

https://piped.video/C_NsmQD6LK8

[Stack Overflow](https://stackoverflow.com/)

### Quick links:

https://git-scm.com/

https://git-lfs.com/

https://unity.com/download

https://brew.sh/

### Troubleshooting

For Linux having issue for SSL: No usable version of libssl was found. 

You need download stable version through: https://pkgs.org/download/libssl1.0.0

Once installed, open project again in Unity Hub or exit safe mode in Unity Engine.

# Video:

YouTube: https://www.youtube.com/watch?v=r-YEbrJ_IZM

Piped: https://piped.video/watch?v=r-YEbrJ_IZM

Invidious: https://invidio.us/watch?v=r-YEbrJ_IZM

# Features
- Only one level
- Hearts (broken of multiplayer only)
- Improved camera
- Spikes
- Cherries
- Finish flag
- Scenes

# TO-DO List (cancelled):

- Add Android & IOS Support
- Scores
- Enemy shoots to the player
- Players life
- Add more levels
- Jump enemy by player to get enemy squashed and score.

# Test cases

Test Scenario | Test Case | Test Data | Excepted Result | Actual Result | Pass / Fail |
--- | --- | --- | --- | --- | --- |
Controls | Jump | W | Player jumps | Player jumps | ✅ |
Controls | Left | A | Player goes left | Player goes left | ✅ |
Controls | Right | D | Player goes right | Player goes right | ✅ |
Levels | Finish line | Checkpoint | Checkpoint goes to next level | Checkpoint goes to next level | ✅ |
Levels | Finish line by second player mode | Checkpoint, if second player did not reached | After the first player reaches, the second player goes to the finish line before the next level. | After the first player reached it, it moved to the next level without two players' assistance. | :x: |
Buttons | Click buttons | Click buttons | The gamer presses the buttons. | The gamer presses the buttons. | ✅ |
Buttons | Different player modes | Click button | The gamer clicks one player mode and the second player is not in this game. | The gamer clicks one player mode and the second player still appears in this game. | :x: |

5 out of 7 were passed the test. 71.42% out of 100% passed.

# Game design document (cancelled)
## Game Identity / Mantra:
The bad guys stole the princess and the good heroes will save anytime using stars.

## Design Pillars:
Strong. Punchable. Speed.

## Genre/Story/Mechanics Summary:
The evil boss named Awelo to kidnap the princess, now the good heroes try to save the princess for anytime now by using the ultimate strong power.

## Features: 
Enemies

Items

Powers

Parkour

Games

Multiplayers

1x Shield every level

Easter eggs

Hiddens

## Interface:
The player controls movements of left, right and jump (x and y), kind of the same standard controllers. The player interacts a little bit angry in his face, he has fist punch power and can defend with his arms for a little movement. For jumping, they can jump across the platforms or double jump with multiplayer.

## Art Style:

Bruforce and Legend of Mana are kinda same to this game, but not really true.

We need to make a difference in this game to avoid copyright infringement and bootlegs.

## Music/Sound: 
We need to add sound effects and background music to the video game and change every background music of every level, including the boss levels music. Sound effects can be found on the internet, but for our own music we need the music artist to make new music to put own music into the game.

Example links for the sound effects and music to the game:

https://piped.video/p64Fjndnt78

https://pixabay.com/music/modern-classical-sacred-garden-10377/

https://piped.video/7_DKroTn4VE

Development Roadmap / Launch Criteria:

Platform: Steam/Google Play/iOS/Web/PC

Audience: 10+/Kids/RPG

~~Milestone 1: Mechanics complete - 24/10/22~~

~~Milestone 2: Boss fights complete - 03/1/23~~

~~Milestone 3: Levels complete -  18/5/23~~

~~Milestone 4: Polish complete - 01/7/23~~

~~Launch Day: 13/8/23~~

# Donate to Martin Eesmaa for a cryptocurrencies

- **BTC (BITCOIN):** 
```
bc1qhf4zu5uythr7vyt2dru73qp0k2rzrx355fsx47yjxc2ueunz8frqxmwap3
```
- **XMR (MONERO):** 
```
46Fk6k3qzhwXpLsDRWo4Uh63DDmwRX7gbL6P3zodAnvnRDr9Psi9uau19nCRQFHbmp3nLR3d5Ve8WRid71nuLZxAGygZ258
```
- **LBRY (Odysee):**
```
bH3eumTBQoAvRCPLZWpirX9ggxeEUs5VaR
```
- **BAT (BASIC ATTENTION TOKEN):** For Brave Browser users only, you can also contribute by supporting me, I'm a verified Brave user on Brave Rewards.

- **Estonian bank account (Luminor Eesti IBAN):** You can donate to me. You have to pay a little network send fees before donate.
```
EE511700017003558571
```

- Martin Eesmaa
