namespace Observer.Data;
class Subscriber{
    public bool state = false;
    public string style;

    public Subscriber(){
        style="background-color: red";
    }
    public void update(){

        state = !state;

        if (state)
            style = "background-color: pink;";
        else
            style = "background-color: orange;";

    }
}