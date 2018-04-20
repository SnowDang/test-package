
# react-native-ad-instream

## Getting started

`$ npm install react-native-ad-instream --save`

### Mostly automatic installation

`$ react-native link react-native-ad-instream`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-ad-instream` and add `RNAdInstream.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNAdInstream.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNAdInstreamPackage;` to the imports at the top of the file
  - Add `new RNAdInstreamPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-ad-instream'
  	project(':react-native-ad-instream').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-ad-instream/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-ad-instream')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNAdInstream.sln` in `node_modules/react-native-ad-instream/windows/RNAdInstream.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Ad.Instream.RNAdInstream;` to the usings at the top of the file
  - Add `new RNAdInstreamPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNAdInstream from 'react-native-ad-instream';

// TODO: What to do with the module?
RNAdInstream;
```
  