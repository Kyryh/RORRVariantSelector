# RORRVariantSelector
A way to choose which stage variant to spawn in [Risk of Rain Returns](https://store.steampowered.com/app/1337520/Risk_of_Rain_Returns/) to make searching for artifacts, environment logs and prisms less of an hassle 

## Installation
- Download and extract the [latest release](/releases/latest)
- Run **RORRVariantSelector.exe**

## Usage
At first you will need to select the game's executable (you can find it inside your steam's directory in \steamapps\common\Risk of Rain Returns)

Then you choose which stage variants you want to get (e.g. if you want variant 1 and 4 of Desolate Forest then you uncheck variants 2, 3, 5, 6 and keep variants 1 and 4 checked)

When you've finished setting the stage variants just press the **Save variants selection** button

Now open *(or restart if you had already opened it)* the game and you should encounter only the variations that you chose

You can restore the original variants whenever you want with the **Restore variants** button

## FAQ
### How does it work?
It first copies all of the *.rorlvl files located in /data/stages/ to a backup folder, then it replaces files only the checked variations.

I know, it's a little bit crude but I couldn't find a way to directly mod the game so this is the next best thing.

### Can I make so that only one stage is chosen (e.g. always Desolate Forest instead of choosing between Desolate Forest and Dried Lake)?
Not at the moment

### Does this work online?
No idea, couldn't test it unfortunately

### Isn't this cheating?
I mean, kind of? It depends on your definition of cheating, because all this is doing is removing the randomness factor; it doesn't become any easier, just faster

## Contributing

Pull requests are welcome, especially to the **StageVariantsSecrets.cs** file since not all the environment logs, prisms and artifacts are marked on the wiki
