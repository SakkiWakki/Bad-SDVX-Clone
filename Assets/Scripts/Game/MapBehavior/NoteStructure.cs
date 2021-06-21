public class NoteStructure {
    string note; 
    int measureCount; 
    int onSectionNum; 
    int totalSectionCount;

    public NoteStructure(string note, int measureCount, int onSectionNum, int totalSectionCount) {
        this.note = note;
        this.measureCount = measureCount;
        this.onSectionNum = onSectionNum;
        this.totalSectionCount = totalSectionCount;
    }
}