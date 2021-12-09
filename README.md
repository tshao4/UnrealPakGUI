# UnrealPakGUI



## Usage

### Files and Directories

#### Engine Dir

This is for finding the <i>UnrealPak.exe</i> executable. It's the path containing unreal's <i>Engine</i> folder, i.e. <i>D:/UnrealEngine/UE_4.26</i>. Alternatively you can copy your <i>UnrealPak.exe</i> to the folder where <i>UnrealPakGUI.exe</i> is and leave this field empty.

#### Crypto File

This is for encrypting/decrypting your pak file. If encryption is not necessary, leave it empty. This file can be found in the <i>Saved</i> folder under your unreal project directory after having packed your project at least once in editor with a crypto key.

#### UProject File

Self-explanatory. This is for getting the project name. Required for the <i>Content Files Only</i> option;

### Options

#### Content Files Only

If checked, only files under "Content" and its subfolders are packed, so the pak mount point will be set to <i>../../../\<ProjectName\>/Content/*</i>. Otherwise mount point is set to the common root directory of the input files. This is intend for the usage where you want to pack cooked assets in the <i>Saved/Cooked/WindowsNoEditor/\<ProjectName\>/Content</i> folder with a valid mount point.

#### Compression

Self-explanatory. Check this if you want to compress your pak file.

#### Encryption

Self-explanatory. Requires a valid <i>Crypto.json</i> file.

### Modes

#### Single Pak

Create a single pak file from the list. Add files/folders by dragging them onto the list. Remove files/folders by selecting them and click <i>Remove</i> or Clear the list by clicking <i>Remove All</i>. Click <i>Create Pak</i> to start packing.

#### Batch Mode

Batch creating pak files to the <i>Output Dir</i>.

Option <i>As Patch</i> - If checked, a suffix <i>_p</i> will be added to each created pak file. Pak files with the <i>_p</i> suffix are considered patches by unreal engine. Contents in a patch pak file will override those in the original game pak file.

Option <i>Folder Pak</i> - This is an ease-of-use option. The default behavior of drag & drop is creating a pak file for each drag & drop operation. If this option is checked, a pak file will be created for each folder in a single drag & drop operation.

#### List & Extract

List pak contents by drag & drop pak file onto the list. Optionally extract its content to the <i>Extract To</i> directory. If the pak file is encrypted, then the option <i>Encryption</i> should be checked and a valid <i>Crypto.json</i> file must be provided.
