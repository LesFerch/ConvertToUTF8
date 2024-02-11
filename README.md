# ConvertToUTF8

Command line tool to convert one or more text files from other encodings (e.g. Shift JIS) to UTF-8.

This was written primarily for converting non-UTF-8 Japanese, Arabic, etc. SRT files, but should work fine on any text file.

Note that there is no harm converting a file that's already UTF-8. All that will happen is any UTF-8 with BOM will be changed to UTF-8 without BOM.

This program uses the [UTF Unknown](https://github.com/CharsetDetector/UTF-unknown) library to detect the source file encoding (aka code page).

**WARNING**: This program overwrites the original file with the converted file! You may want to make a backup copy first!

[![image](https://user-images.githubusercontent.com/79026235/152910441-59ba653c-5607-4f59-90c0-bc2851bf2688.png)Download the zip file](https://github.com/LesFerch/ConvertToUTF8/releases/download/1.0.0/ConvertToUTF8.zip)

## How to Download and Run

1. Download the zip file using the link above.
2. Extract **ConvertToUTF8.exe** and **UtfUnknown.dll**.
3. Right-click **ConvertToUTF8.exe**, select Properties, check Unblock, and click OK.
4. Optionally move **ConvertToUTF8.exe** and **UtfUnknown.dll** to the folder of your choice.
5. Drag and drop text files onto **ConvertToUTF8.exe** to convert them to UTF-8. Or run it from the command line.
6. If you skipped step 3, then, in the SmartScreen window, click More info and then Run anyway.

**Note**: Some antivirus software may falsely detect the download as a virus. This can happen any time you download a new executable and may require extra steps to whitelist the file.

[![image](https://user-images.githubusercontent.com/79026235/153264696-8ec747dd-37ec-4fc1-89a1-3d6ea3259a95.png)](https://github.com/LesFerch/ConvertToUTF8)
