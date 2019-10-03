# CSharp-ChatUI-Winforms


This documentation will be complete in 24hours...06/10/2019. I WILL INSTANTLY UPDATE ONCE I COMPLETE WRITING.

I was searching for a beautiful Chat bubble for C# winform, but the only one i could find was that of Telerik which was not free. So i decided to write one.

## ScreenShots

![Alt text](https://github.com/AbdisamadMoh/CSharp-ChatUI-Winforms/blob/master/Scr1.PNG?raw=true "")
![Alt text](https://github.com/AbdisamadMoh/CSharp-ChatUI-Winforms/blob/master/Scr2.PNG?raw=true "")


## Usage
If you r going to use these chat components in your project, I recommed you to use <b>ChatUI.dll</b> in the folder <b>ChatUI Compiled DLL,</b>. In this <b>ChatUI.dll</b> I have compiled all 7 components in this project.
Just drag the dll file into ur visual studio toolbox. Copy the dll file, create new tab in ur visual studio toolbox and paste.


### Components
##### <a href="#BeautyForm">BeautyForm</a>
##### <a href="#ChatHeader">ChatHeader</a>
##### <a href="#TypingBox">TypingBox</a>
##### <a href="#SearchBox">SearchBox</a>
##### <a href="#Users">Users</a>
##### <a href="#Bubbles">Bubbles (2)</a>

### <div id="BeautyForm"> BeautyForm</div>
A beautiful form with with round corners. See screenshots above.
 ``` C#
public partial class Form1 : chat.BeautyForm
    {
        public Form1()
        {
            InitializeComponent();
        }
```
### <div id="#ChatHeader">ChatHeader</div>
See screenshots above, the uppermost part where user details is displayed. It has User profile image, title, status, call, video call, dot menu.

 ``` C#
chat.ChatHeader chatHeader1 = new chat.ChatHeader();

chatHeader1.UserTitle = "Abdisamad Moh."; // Gets/Sets user title
chatHeader1.UserStatusText = "Typing..."; // Gets/Sets User status text.
chatHeader1.UserImage = Some_Image; // Gets/Sets User profile image

chatHeader1.OnCallClick+= Double tab to complete. // Fires when user clicks  Call icon
chatHeader1.OnVideoCallClick+= Double tab to complete. // Fires when user clicks Video Call icon
chatHeader1.OnUserImageClick+= Double tab to complete. // Fires when user clicks  Profile Image
chatHeader1.OnUserStatusTextClick+= Double tab to complete. // Fires when user clicks User status Text
chatHeader1.OnUserTitleClick+= Double tab to complete. // Fires when user clicks User Title Text
chatHeader1.OnMenuDotClick+= Double tab to complete. // Fires when user clicks Dot menu

```

### <div id="#TypingBox">TypingBox</div>
Beautiful User typing box with embedded Emoji icon, File attachment icon.

 ``` C#
 chat.TypingBox typingBox1 = new chat.TypingBox();

typingBox1.Value = "Hi"; //Gets/Sets text of the typingBox.

typingBox1.OnTypingTextChanged+= Double tab to complete. // Fires when user writes something into the typingBox. This fires per character.
typingBox1.OnHitEnter+= Double tab to complete. // Fires when user hits ENTER key while the typingBox is focused. This fires before newline is created in the typingBox. SHIFT+ENTER will also create newline without firing this event.
typingBox1.OnEmojiClicked+= Double tab to complete. // Fires when user clicks Emoji icon in the typingBox.
typingBox1.OnAttachmentClicked+= Double tab to complete. // Fires when user clicks File attachment icon in the typingBox.

```

### <div id="#SearchBox">SearchBox</div>
See the screenshots above, that textbox with 'search watermark' and underlining line, That is  searchBox.

 ``` C#
chat.SearchBox searchBox1 = new chat.SearchBox();

searchBox1.Value = "Something"; //Gets/Sets value in the searchBox.
searchBox1.TextColor =Color.GradientActiveCaption; //Gets/Sets text color and the bottom line color of the searchBox.
searchBox1.FocusedColor =  Color.WhiteSmoke; //Gets/Sets text color and the bottom line color of the searchBox when it is focused.
searchBox1.UnFocusedColor = Color.GradientActiveCaption; //Gets/Sets text color and the bottom line color of the searchBox when it is not focused.

searchBox1.OnSearchTextChanged+= Double tab to complete. // Fires when user writes something into the typingBox. This fires per character.
searchBox1.OnHitEnter+= Double tab to complete. // Fires when user hits ENTER key while the searchBox is focused. 

```

### <div id="#Users">Users</div>
-Documentation still writing...WILL BE AVAILABLE IN 24HRS. 06/10/2019

### <div id="#Bubbles">Bubbles (2)</div>
-Documentation still writing...WILL BE AVAILABLE IN 24HRS. 06/10/2019










