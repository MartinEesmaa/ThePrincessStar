# The Princess Star (deprecated & archived)

***NOTE: This game is no longer development anymore.***

# Build

Before you build this game, you need Git with LFS and Unity Hub with your Unity account & any version (example latest LTS version).

For Windows: [Download link](https://git-scm.com/download/win).

For macOS: `brew install git-lfs`. You need [Homebrew](https://brew.sh/).

For Linux: `sudo apt install git-lfs`. 

For Fedora, replace apt with dnf. Other OS:

1: Clone with LFS support:
```
git lfs clone --depth=1 https://github.com/MartinEesmaa/ThePrincessStar
```

2: Click "Open project" in Unity Hub, select my game and it will automatically open the project, when it's first time.

This could take about couple minutes for loading project for first time. After first time open, it's ready to run faster, when opening project again.

3: Once Unity Engine opens up, go to File -> Build & Run or Build Settings. Select any folders or create folder to compile the game.

For additional compression, go to Build Settings and select compression method for LZ4HC.

4: Enjoy and run the game :).

### Quick links:

https://git-scm.com/

https://git-lfs.com/

https://unity.com/download

https://brew.sh/

### Troubleshooting

For Linux having issue for SSL: No usable version of libssl was found. 

You need download stable version through: https://pkgs.org/download/libssl1.0.0

Once installed, open project again in Unity Hub or exit safe mode in Unity Engine.

# Screenshot:
![princessstarunity](https://user-images.githubusercontent.com/88035011/196579623-7c471b08-f19e-4807-ad86-0573383e8515.png)

# Video:

YouTube: https://www.youtube.com/watch?v=r-YEbrJ_IZM

Piped: https://piped.video/watch?v=r-YEbrJ_IZM

Invidious: https://invidio.us/watch?v=r-YEbrJ_IZM

# Features
- Levels
- Hearts (broken of multiplayer only)
- Improved camera
- Loading screen

# TO-DO List:

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

5 out of 7 were passed the test. 71,42% passed

# Donate to Martin Eesmaa for a cryptocurrencies

- **BTC (BITCOIN):** 
```
bc1qhf4zu5uythr7vyt2dru73qp0k2rzrx355fsx47yjxc2ueunz8frqxmwap3
```
- **XMR (MONERO):** 
```
46Fk6k3qzhwXpLsDRWo4Uh63DDmwRX7gbL6P3zodAnvnRDr9Psi9uau19nCRQFHbmp3nLR3d5Ve8WRid71nuLZxAGygZ258
```
- **BAT (BASIC ATTENTION TOKEN):** For Brave Browser users only, you can also contribute by supporting me, I'm a verified Brave user on Brave Rewards.

- **Estonian bank account (Luminor Eesti IBAN):** You can donate to me. You have to pay a little network send fees before donate.
```
EE511700017003558571
```

- Martin Eesmaa
