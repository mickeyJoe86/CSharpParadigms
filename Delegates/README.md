Delegates
=========

Delegates in C# are similar to delegates in JavaScript.  In JS, methods can be saved into variables to be passed as parameters to other methods--often used to wire up button click handlers.

Delegates perform similarly in C#, though they also hold a reference type and parameter list.

###Consider the vanilla JS example below:
    
    <input type="submit" value="Click for message" id="submitButton">    
    
    <script>
    var button = document.getElementById("submitButton");

    var alertMessage = function() {
        alert("Message Text");
    }
    
    button.onclick = alertMessage;
    </script>

The action of the alertMessage delegate is triggered by the onClick method of button.  

###In C# Delegates perform similarly:

but enforce a return type and can be called by any method with the same return type and signature.  So, various subscribers can call the same delegate.

