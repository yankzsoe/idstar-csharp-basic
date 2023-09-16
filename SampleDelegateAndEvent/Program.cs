namespace SampleDelegateAndEvent {
    public delegate void MyDelegate(char charPressed);

    internal class MyDelegateAndEvent {
        public event MyDelegate? MyDelegateEventHandler;

        public void OnButtonHanlderTriggered(char charPressed) {
            if (MyDelegateEventHandler == null) {
                Console.WriteLine("Please press your keyboard.");
                return;
            }

            MyDelegateEventHandler?.Invoke(charPressed);
        }
    }

    internal class Program {
        static void Main(string[] args) {
            var myDelegate = new MyDelegateAndEvent();
            myDelegate.OnButtonHanlderTriggered(char.MinValue);

            myDelegate.MyDelegateEventHandler += (character) => {
                Console.WriteLine($"Keyboard was pressed is: {character}");
            };

        Start:

            var keyCode = Console.ReadKey(true).KeyChar;
            myDelegate.OnButtonHanlderTriggered(keyCode);

            goto Start;
        }
    }
}