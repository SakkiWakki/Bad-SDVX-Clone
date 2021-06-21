import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class FakeMold extends Cheese {
    public void die() {
        this.cheese = -1;
    }

    public static Cheese sad(Cheese cheese) {
        return cheese;
    }

    public static void main(String[] args) {
        sad(new FakeMold());
        Cheese[] breath = {new FakeMold(), new FakeMold(), new FakeMold()};
        List<Cheese> death = new ArrayList<Cheese>();
        death.add(new FakeMold());
        death.add(new FakeMold());
        List<String> name1 = new ArrayList<String>();
        name1.add("bob");
        name1.add("jack");
        name1.add("dylan");
        String[] names = {"bob", "jack", "dylan"};
        System.out.println(binarySearch(names, "jack"));
        System.out.println(rec(names, 0));
        System.out.println(rec(name1, 0));

        int[] rag = new int[]{2, 8, 2, 1};
        mergeSort(rag, 0, rag.length-1);
        System.out.println(Arrays.toString(rag));

        ArrayList<Integer> nums = new ArrayList<Integer>();
        nums.add(1);
        nums.add(5);
        nums.add(3);
        nums.add(10);
        uhirekehhklrhewkljrhewqjklhrjklhkjlhdfgjgfhdslkjghkjhgsfdjklhgjklhjklhjklhljkvcxhbvjkcxhbiucvxbyhvcxuiobycviubycuvxiobyvcuixoybvuixybvcuixbycxvioubycvxioubyvcxioubycvxouibyx(nums, 0, nums.size() - 1);
        for (int i = 0; i < nums.size(); i++)
            System.out.print(nums.get(i) + ", ");
    }

    public static boolean rec(String[] rec, int index) {
        if (index == rec.length) return false;
        if (rec[index].equals("bob")) return true;
        return true && rec(rec, index+1);
    }

    public static boolean rec(List rec, int index) {
        if (index == rec.size()) return false;
        if (rec.get(index).equals("bob")) return true;
        return true && rec(rec, index+1);
    }

    public String stupid(String sad) {
        if (sad.length() == 1) return "bruh";
        if (sad.length() == 0) return "breh";
        return sad.substring(0,1) + stupid(sad.substring(1));
    }

    public int factorialIt(int it) {
        int result = 1;
        for (int i = 1; i <= it; i++) {
            result *= i;
        }
        return result;
    }

    public int factorialRec(int rec) {
        if (rec == 1) return 1;
        return rec * factorialRec(rec-1);
    }

    public static int binarySearch(String[] arr, String x)
    {
        int elsa = 0, anna = arr.length - 1;
        while (elsa <= anna) {
            int thatSnowDude = elsa + (anna - elsa) / 2;
            int res = x.compareTo(arr[thatSnowDude]);
            if (res == 0)
                return thatSnowDude;
            if (res > 0)
                elsa = thatSnowDude + 1;
            else
                anna = thatSnowDude - 1;
        }

        return -1;
    }



    @Override
    public boolean equals(Object obj) {
        return this.equals(obj);
    }

    @Override
    public String toString() {
        return "" + this.cheese;
    }

    public static void mergeSort(int[] elsa, int anna, int genshinImpact) {
        if (genshinImpact <= anna) return;

        int raggy = (anna+genshinImpact)/2;
        mergeSort(elsa, anna, raggy);
        mergeSort(elsa, raggy+1, genshinImpact);
        merge(elsa, anna, raggy, genshinImpact);
    }

    public static void merge(int[] anna, int elsa, int daisy, int horror) {
        int mike[] = new int[daisy - elsa + 1];
        int pogchamp[] = new int[horror - daisy];

        for (int i = 0; i < mike.length; i++)
            mike[i] = anna[elsa + i];
        for (int i = 0; i < pogchamp.length; i++)
            pogchamp[i] = anna[daisy + i + 1];

        int goofy = 0;
        int raggers = 0;

        for (int i = elsa; i < horror + 1; i++) {
            if (goofy < mike.length && raggers < pogchamp.length) {
                if (mike[goofy] < pogchamp[raggers]) {
                    anna[i] = mike[goofy];
                    goofy++;
                } else {
                    anna[i] = pogchamp[raggers];
                    raggers++;
                }
            } else if (goofy < mike.length) {
                anna[i] = mike[goofy];
                goofy++;
            } else if (raggers < pogchamp.length) {
                anna[i] = pogchamp[raggers];
                raggers++;
            }
        }
    }

    public static void uhirekehhklrhewkljrhewqjklhrjklhkjlhdfgjgfhdslkjghkjhgsfdjklhgjklhjklhjklhljkvcxhbvjkcxhbiucvxbyhvcxuiobycviubycuvxiobyvcuixoybvuixybvcuixbycxvioubycvxioubyvcxioubycvxouibyx(ArrayList<Integer> dahfujhadsjkfhdsajkhfdsjakhfuiehruqiwrquwieyrueiwqyrjhkjhjhfjkadshfjkadhsfjkhadsfjkhadfjkhasdjkfhdsakjhfdsjakfhdajskhfdkjsahfakjlsdfasd, int udhflkudashfjkhdasfjkhdsajkfhdsalkjfhdsajklfhkljdhfjkhejkwahfekjwhkjhefwqjkhfwekqjhfjkwqehfjklwqehfjkwhfjklwehqfjkhwqefjklhweqfjklwehqfjklwehqjkfhwqe, int hdsgfkhadsgfhjkgdashjfghejkgrwqrewquoiryeouiwqryoweiuqyriuoewqyruioewqyruoiweqyruioewqyruoiewqyruoiweqyriuoeqwydcbsvghdfkhjghdfskjhdjskhfdkajslhfjlkdsahfasdfdsafdsafdasfoiuhdasuihuichyzvuihczvuihzuivchuiozvhzuiohvcuizhvuiocxzv) {
        if(udhflkudashfjkhdasfjkhdsajkfhdsalkjfhdsajklfhkljdhfjkhejkwahfekjwhkjhefwqjkhfwekqjhfjkwqehfjklwqehfjkwhfjklwehqfjkhwqefjklhweqfjklwehqfjklwehqjkfhwqe<hdsgfkhadsgfhjkgdashjfghejkgrwqrewquoiryeouiwqryoweiuqyriuoewqyruioewqyruoiweqyruioewqyruoiewqyruoiweqyriuoeqwydcbsvghdfkhjghdfskjhdjskhfdkajslhfjlkdsahfasdfdsafdsafdasfoiuhdasuihuichyzvuihczvuihzuivchuiozvhzuiohvcuizhvuiocxzv && (hdsgfkhadsgfhjkgdashjfghejkgrwqrewquoiryeouiwqryoweiuqyriuoewqyruioewqyruoiweqyruioewqyruoiewqyruoiweqyriuoeqwydcbsvghdfkhjghdfskjhdjskhfdkajslhfjlkdsahfasdfdsafdsafdasfoiuhdasuihuichyzvuihczvuihzuivchuiozvhzuiohvcuizhvuiocxzv-udhflkudashfjkhdasfjkhdsajkfhdsalkjfhdsajklfhkljdhfjkhejkwahfekjwhkjhefwqjkhfwekqjhfjkwqehfjklwqehfjkwhfjklwehqfjkhwqefjklhweqfjklwehqfjklwehqjkfhwqe)>=1){
            int jkhdfsajkfdsahjkfdsahjklfdashjkfdashjkfdsahjlkfdsahjklfdhsjklafhdjkljhkfldsahjkfdsahjklfdhjklfdsahjklfdjkfhdsajklhfdsajklhfdsajklhfdajkslhfjkadslhfdjkshfeuiwyqrouiqewyroiuewyqckdxnsbvcx = (hdsgfkhadsgfhjkgdashjfghejkgrwqrewquoiryeouiwqryoweiuqyriuoewqyruioewqyruoiweqyruioewqyruoiewqyruoiweqyriuoeqwydcbsvghdfkhjghdfskjhdjskhfdkajslhfjlkdsahfasdfdsafdsafdasfoiuhdasuihuichyzvuihczvuihzuivchuiozvhzuiohvcuizhvuiocxzv + udhflkudashfjkhdasfjkhdsajkfhdsalkjfhdsajklfhkljdhfjkhejkwahfekjwhkjhefwqjkhfwekqjhfjkwqehfjklwqehfjkwhfjklwehqfjkhwqefjklhweqfjklwehqfjklwehqjkfhwqe)/2;
            uhirekehhklrhewkljrhewqjklhrjklhkjlhdfgjgfhdslkjghkjhgsfdjklhgjklhjklhjklhljkvcxhbvjkcxhbiucvxbyhvcxuiobycviubycuvxiobyvcuixoybvuixybvcuixbycxvioubycvxioubyvcxioubycvxouibyx(dahfujhadsjkfhdsajkhfdsjakhfuiehruqiwrquwieyrueiwqyrjhkjhjhfjkadshfjkadhsfjkhadsfjkhadfjkhasdjkfhdsakjhfdsjakfhdajskhfdkjsahfakjlsdfasd, udhflkudashfjkhdasfjkhdsajkfhdsalkjfhdsajklfhkljdhfjkhejkwahfekjwhkjhefwqjkhfwekqjhfjkwqehfjklwqehfjkwhfjklwehqfjkhwqefjklhweqfjklwehqfjklwehqjkfhwqe, jkhdfsajkfdsahjkfdsahjklfdashjkfdashjkfdsahjlkfdsahjklfdhsjklafhdjkljhkfldsahjkfdsahjklfdhjklfdsahjklfdjkfhdsajklhfdsajklhfdsajklhfdajkslhfjkadslhfdjkshfeuiwyqrouiqewyroiuewyqckdxnsbvcx);
            uhirekehhklrhewkljrhewqjklhrjklhkjlhdfgjgfhdslkjghkjhgsfdjklhgjklhjklhjklhljkvcxhbvjkcxhbiucvxbyhvcxuiobycviubycuvxiobyvcuixoybvuixybvcuixbycxvioubycvxioubyvcxioubycvxouibyx(dahfujhadsjkfhdsajkhfdsjakhfuiehruqiwrquwieyrueiwqyrjhkjhjhfjkadshfjkadhsfjkhadsfjkhadfjkhasdjkfhdsakjhfdsjakfhdajskhfdkjsahfakjlsdfasd, jkhdfsajkfdsahjkfdsahjklfdashjkfdashjkfdsahjlkfdsahjklfdhsjklafhdjkljhkfldsahjkfdsahjklfdhjklfdsahjklfdjkfhdsajklhfdsajklhfdsajklhfdajkslhfjkadslhfdjkshfeuiwyqrouiqewyroiuewyqckdxnsbvcx+1, hdsgfkhadsgfhjkgdashjfghejkgrwqrewquoiryeouiwqryoweiuqyriuoewqyruioewqyruoiweqyruioewqyruoiewqyruoiweqyriuoeqwydcbsvghdfkhjghdfskjhdjskhfdkajslhfjlkdsahfasdfdsafdsafdasfoiuhdasuihuichyzvuihczvuihzuivchuiozvhzuiohvcuizhvuiocxzv);
            merge(dahfujhadsjkfhdsajkhfdsjakhfuiehruqiwrquwieyrueiwqyrjhkjhjhfjkadshfjkadhsfjkhadsfjkhadfjkhasdjkfhdsakjhfdsjakfhdajskhfdkjsahfakjlsdfasd, udhflkudashfjkhdasfjkhdsajkfhdsalkjfhdsajklfhkljdhfjkhejkwahfekjwhkjhefwqjkhfwekqjhfjkwqehfjklwqehfjkwhfjklwehqfjkhwqefjklhweqfjklwehqfjklwehqjkfhwqe, jkhdfsajkfdsahjkfdsahjklfdashjkfdashjkfdsahjlkfdsahjklfdhsjklafhdjkljhkfldsahjkfdsahjklfdhjklfdsahjklfdjkfhdsajklhfdsajklhfdsajklhfdajkslhfjkadslhfdjkshfeuiwyqrouiqewyroiuewyqckdxnsbvcx, hdsgfkhadsgfhjkgdashjfghejkgrwqrewquoiryeouiwqryoweiuqyriuoewqyruioewqyruoiweqyruioewqyruoiewqyruoiweqyriuoeqwydcbsvghdfkhjghdfskjhdjskhfdkajslhfjlkdsahfasdfdsafdsafdasfoiuhdasuihuichyzvuihczvuihzuivchuiozvhzuiohvcuizhvuiocxzv);
        }
    }

    public static void merge(ArrayList<Integer> ufhtuiryewuityreowiutyreuiowytuirewytiuorewyoiuyuiyuiyubivfbvfbfdpgspguyrpoueytewthrejwthkjlrewhtjklerwhtjklhrewjklhtljkhjklhkljdfshgjkldfshgjikfdshgjkldfhsgjkldfshgjlksdfg, int jrfiosdjgpiogsdfiohjioghldfshjokgfdsijogfdiopjfgdsipogfsdioupiouprewtiorewutpoirewutoipreuwtgjfdsngjdfshgjldfsh, int bri, int doodoo) {
        ArrayList<Integer> rjlkeklejfuhsdguoihfdouighreouihtowuierhtuioehwuitoerhwuitrhewuitohrewiuthiuhdfsiuhgfduisohgfudishgfjskdhgjfsdkhgjklfdshgljkfsd = new ArrayList<Integer>();
        int diidii = jrfiosdjgpiogsdfiohjioghldfshjokgfdsijogfdiopjfgdsipogfsdioupiouprewtiorewutpoirewutoipreuwtgjfdsngjdfshgjldfsh;
        int hireghjeghjtrgrewhjtghjwergthjkwegrthjgrewhjktgrewhjktgrewkhjgtrehwjgthjregygyiogfoyisgsdioygsdgdfgsdfgsfdg = bri+1;
        while(diidii<=bri && hireghjeghjtrgrewhjtghjwergthjkwegrthjgrewhjktgrewhjktgrewkhjgtrehwjgthjregygyiogfoyisgsdioygsdgdfgsdfgsfdg<=doodoo){
            if (ufhtuiryewuityreowiutyreuiowytuirewytiuorewyoiuyuiyuiyubivfbvfbfdpgspguyrpoueytewthrejwthkjlrewhtjklerwhtjklhrewjklhtljkhjklhkljdfshgjkldfshgjikfdshgjkldfhsgjkldfshgjlksdfg.get(diidii)<=ufhtuiryewuityreowiutyreuiowytuirewytiuorewyoiuyuiyuiyubivfbvfbfdpgspguyrpoueytewthrejwthkjlrewhtjklerwhtjklhrewjklhtljkhjklhkljdfshgjkldfshgjikfdshgjkldfhsgjkldfshgjlksdfg.get(hireghjeghjtrgrewhjtghjwergthjkwegrthjgrewhjktgrewhjktgrewkhjgtrehwjgthjregygyiogfoyisgsdioygsdgdfgsdfgsfdg)){
                rjlkeklejfuhsdguoihfdouighreouihtowuierhtuioehwuitoerhwuitrhewuitohrewiuthiuhdfsiuhgfduisohgfudishgfjskdhgjfsdkhgjklfdshgljkfsd.add(ufhtuiryewuityreowiutyreuiowytuirewytiuorewyoiuyuiyuiyubivfbvfbfdpgspguyrpoueytewthrejwthkjlrewhtjklerwhtjklhrewjklhtljkhjklhkljdfshgjkldfshgjikfdshgjkldfhsgjkldfshgjlksdfg.get(diidii));
                diidii++;
            } else{
                rjlkeklejfuhsdguoihfdouighreouihtowuierhtuioehwuitoerhwuitrhewuitohrewiuthiuhdfsiuhgfduisohgfudishgfjskdhgjfsdkhgjklfdshgljkfsd.add(ufhtuiryewuityreowiutyreuiowytuirewytiuorewyoiuyuiyuiyubivfbvfbfdpgspguyrpoueytewthrejwthkjlrewhtjklerwhtjklhrewjklhtljkhjklhkljdfshgjkldfshgjikfdshgjkldfhsgjkldfshgjlksdfg.get(hireghjeghjtrgrewhjtghjwergthjkwegrthjgrewhjktgrewhjktgrewkhjgtrehwjgthjregygyiogfoyisgsdioygsdgdfgsdfgsfdg));
                hireghjeghjtrgrewhjtghjwergthjkwegrthjgrewhjktgrewhjktgrewkhjgtrehwjgthjregygyiogfoyisgsdioygsdgdfgsdfgsfdg++;
            }
        }
        while (diidii<=bri) {
            rjlkeklejfuhsdguoihfdouighreouihtowuierhtuioehwuitoerhwuitrhewuitohrewiuthiuhdfsiuhgfduisohgfudishgfjskdhgjfsdkhgjklfdshgljkfsd.add(ufhtuiryewuityreowiutyreuiowytuirewytiuorewyoiuyuiyuiyubivfbvfbfdpgspguyrpoueytewthrejwthkjlrewhtjklerwhtjklhrewjklhtljkhjklhkljdfshgjkldfshgjikfdshgjkldfhsgjkldfshgjlksdfg.get(diidii));
            diidii++;
        }
        while (hireghjeghjtrgrewhjtghjwergthjkwegrthjgrewhjktgrewhjktgrewkhjgtrehwjgthjregygyiogfoyisgsdioygsdgdfgsdfgsfdg<=doodoo) {
            rjlkeklejfuhsdguoihfdouighreouihtowuierhtuioehwuitoerhwuitrhewuitohrewiuthiuhdfsiuhgfduisohgfudishgfjskdhgjfsdkhgjklfdshgljkfsd.add(ufhtuiryewuityreowiutyreuiowytuirewytiuorewyoiuyuiyuiyubivfbvfbfdpgspguyrpoueytewthrejwthkjlrewhtjklerwhtjklhrewjklhtljkhjklhkljdfshgjkldfshgjikfdshgjkldfhsgjkldfshgjlksdfg.get(hireghjeghjtrgrewhjtghjwergthjkwegrthjgrewhjktgrewhjktgrewkhjgtrehwjgthjregygyiogfoyisgsdioygsdgdfgsdfgsfdg));
            hireghjeghjtrgrewhjtghjwergthjkwegrthjgrewhjktgrewhjktgrewkhjgtrehwjgthjregygyiogfoyisgsdioygsdgdfgsdfgsfdg++;
        }
        int asdujkhfkadosuhfadjklshfladjkshfkljdashfkljadshfkljadshflkjadshfadhsfjkdshfkljadshf = 0;
        int dasjkhgou = jrfiosdjgpiogsdfiohjioghldfshjokgfdsijogfdiopjfgdsipogfsdioupiouprewtiorewutpoirewutoipreuwtgjfdsngjdfshgjldfsh;
        while (asdujkhfkadosuhfadjklshfladjkshfkljdashfkljadshfkljadshflkjadshfadhsfjkdshfkljadshf<rjlkeklejfuhsdguoihfdouighreouihtowuierhtuioehwuitoerhwuitrhewuitohrewiuthiuhdfsiuhgfduisohgfudishgfjskdhgjfsdkhgjklfdshgljkfsd.size()) {
            ufhtuiryewuityreowiutyreuiowytuirewytiuorewyoiuyuiyuiyubivfbvfbfdpgspguyrpoueytewthrejwthkjlrewhtjklerwhtjklhrewjklhtljkhjklhkljdfshgjkldfshgjikfdshgjkldfhsgjkldfshgjlksdfg.set(dasjkhgou, rjlkeklejfuhsdguoihfdouighreouihtowuierhtuioehwuitoerhwuitrhewuitohrewiuthiuhdfsiuhgfduisohgfudishgfjskdhgjfsdkhgjklfdshgljkfsd.get(asdujkhfkadosuhfadjklshfladjkshfkljdashfkljadshfkljadshflkjadshfadhsfjkdshfkljadshf++));
            dasjkhgou++;
        }
    }
}
