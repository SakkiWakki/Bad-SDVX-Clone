public class Mold extends Cheese {
    public int mold;
    public Mold() {
        super();
    }

    public Mold(int mold) {
        super(mold);
    }

    public void die() {
        this.cheese = 1;
        die(1);
    }

    @Override
    public boolean equals(Object obj) {
        return this.equals(obj);
    }

    @Override
    public String toString() {
        return "" + this.cheese;
    }
}
