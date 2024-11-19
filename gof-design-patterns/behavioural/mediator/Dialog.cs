namespace gof_design_patterns.behavioural.mediator
{
    public class Dialog : Mediator
    {
        string title = "";
        Button confirmButton, cancelButton;
        Textbox usernameText, passwordText, emailText;

        public Dialog()
        {
            this.confirmButton = new Button();
            this.cancelButton = new Button();

            this.usernameText = new Textbox();
            this.passwordText = new Textbox();
            this.emailText = new Textbox();
        }

        public void Notify(Component sender, string e)
        {
            if (sender == confirmButton && e == "click")
            {
                title = "Logging in...";
                // username.text = ...
            }
            else if (sender == cancelButton && e == "click")
            {
                title = "Cancelling logging in...";
            }
        }
    }
}
