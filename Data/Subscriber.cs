namespace Observer.Data;
class Subscriber{
    public bool state = false;
    public string style;

    public Subscriber(){
        style="background-color: red";
    }
    public virtual void update(){

        state = !state;

        if (state)
            style = "background-color: pink;";
        else
            style = "background-color: orange;";

    }
}

class Sub2 : Subscriber {
    public override void update(){
        state = !state;

        if (state)
            style = "background-color: orange;";
        else
            style = "background-color: grey;";
    }
}