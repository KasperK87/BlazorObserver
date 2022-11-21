namespace Observer.Data;

class Publisher {
    public List<Subscriber> subscribers;

    public Publisher(){
        subscribers = new List<Subscriber>();
    }

    public void updateSubscribers(){
        foreach(var sub in subscribers){
            sub.update();
        }
    }
}