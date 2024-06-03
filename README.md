
# react-native-hockey-tournament

## Getting started

`$ npm install react-native-hockey-tournament --save`

### Mostly automatic installation

`$ react-native link react-native-hockey-tournament`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-hockey-tournament` and add `RNHockeyTournament.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNHockeyTournament.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNHockeyTournamentPackage;` to the imports at the top of the file
  - Add `new RNHockeyTournamentPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-hockey-tournament'
  	project(':react-native-hockey-tournament').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-hockey-tournament/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-hockey-tournament')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNHockeyTournament.sln` in `node_modules/react-native-hockey-tournament/windows/RNHockeyTournament.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Hockey.Tournament.RNHockeyTournament;` to the usings at the top of the file
  - Add `new RNHockeyTournamentPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNHockeyTournament from 'react-native-hockey-tournament';

// TODO: What to do with the module?
RNHockeyTournament;
```
  