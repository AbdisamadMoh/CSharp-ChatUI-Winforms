# C# ChatUI
### Beautiful and responsive c# windform Chat bubble/chat speech.
I was searching for a beautiful Chat bubble for C# winform, but the only one i could find was that of Telerik which was not free. So i decided to write one.

#### Check SaaUI at <a href="https://saabytes.com">https://saabytes.com</a>, it has chat bubble and alot more beautiful controls and is free for both personal and commercial use.
## ScreenShots

![Alt text](https://github.com/AbdisamadMoh/CSharp-ChatUI-Winforms/blob/master/Scr1.PNG?raw=true "")
![Alt text](https://github.com/AbdisamadMoh/CSharp-ChatUI-Winforms/blob/master/Scr2.PNG?raw=true "")


## Usage

All components in this project are responsive and u dont need to worry about when ur window or container resizes. They will also resize them with the same space percentage, and their look will be same.



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
Beautiful and customizable User control with Profile image, Username(Title name), user status text, user status mode.
See users on left side in the screenshots above.
 ``` C#
chat.Users user1= new chat.Users();

user1.Username = "Abdisamad Moh."; // Gets/Sets username or user title.
user1.UserStatus = Status.Online; //Option/Enum, Gets/Sets user status mode. Online, Away, Offline. U can add more if u want.
user1.StatusMessage = "Online"; //Gets/Sets status message
user1.UserImage = Some_Image;//Gets/Sets User profile image.
user1.ProfileImageCursor = Cursors.Hand; //Gets/Sets mouse cursor when user hovers mouse pointer over userImage.

user1.OnClick +=  Double tab to complete. // Fires when anywhere on the user is clicked Including Username, statusText and StatusMode. However they will be excluded if u give them their own event.
user1.OnUserTitleClick +=  Double tab to complete. // will fire when user clicks Username/Title. In this case, user1.OnClick will not be fired when user clicks on Username/Title.
user1.OnUserStatusClick +=  Double tab to complete. // will fire when user clicks user status text. In this case, user1.OnClick will not be fired when user clicks on user status text..
user1.OnUserStatusClick +=  Double tab to complete. // will fire when user clicks user status mode icon. In this case, user1.OnClick will not be fired when user clicks on user status mode icon.
user1.OnProfileImageClick +=  Double tab to complete. // will fire when user clicks user profile image. In this case, user1.OnClick will not be fired when user clicks on user profile image.

//NOTE: Always use  'OnClick' event for this control instead of 'Click' event. 'OnClick' will take care of all other sub events. Double clicking this control on design time will generate 'Click' event instead of 'OnClick' event which is not recommended. In your Properties explorer find 'OnClick' event and double click to generate 'OnClick' event.

```

### <div id="#Bubbles">Bubbles (2)</div>
See screenshots, those chating messages are the speech bubble. in this Project there are two bubbles, 'MeBubble' and 'YouBubble'. Both have same properties and events but their usage is different. 'MeBubble' is for outgoing chats and 'YouBubble' is for incoming chats.

In this example i will use 'MeBubble'. Both works same way, have same properties and events. Only the name and the usage are different.

 ``` C#
chat.MeBubble meBubble1 = new chat.MeBubble();

meBubble1.Body = "This is a sample message text"; //Gets/Sets message body.
meBubble1.MsgColor = Color.DodgerBlue; //Gets/Sets Message background color. 
//NOTE: 'BackColor' will change the whole control's background color while 'MsgColor' will only change the message Body part.
meBubble1.MsgTextColor = Color.White;//Gets/Sets message text color.
meBubble1.ChatImageCursor = Cursors.Default; //Gets/Sets mouse cursor when it hovers over Bubble profile image.
meBubble1.ChatTextCursor = Cursors.IBeam; //Gets/Sets mouse cursor when it hovers over chat body.
meBubble1.Status = MessageStatus.Delivered;//Option/Enum, Gets/Sets Message status. This is the tick option. Options:  Sending, Sent, Delivered, Read,  Error,  None, Custom. where None will hide the tick option and Custom will give u option to put what u want.
meBubble1.StatusImage = Some_Image; //Gets/Sets custom image for the message status option, that is the tick option.
meBubble1.Time = "11:44 PM"; //Gets/Sets time of the chat bubble.
meBubble1.TimeColor = Color.White; //Gets/Sets Text Color of the time.
meBubble1.UserImage = Some_Image; //Gets/Sets Image of the bubble profile image.

meBubble1.OnChatTextClick+= Double tab to complete. //Fires when user clicks message body part.
meBubble1.OnChatImageClick+= Double tab to complete. //Fires when user clicks the Profile picture of the bubble..


```





## MIT License

Copyright (c) Abdisamad Moh

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice may(or not) be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.





