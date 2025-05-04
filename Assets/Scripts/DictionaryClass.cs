using System.Collections.Generic;
using UnityEngine;

public class DictionaryClass
{
    public Dictionary<string, Vector3[]> environmentDisplacement = new Dictionary<string, Vector3[]>();
    public Dictionary<string, Vector3> destinationPoint = new Dictionary<string, Vector3>();
    private float xwall = 40;
    private float zwall =  128.94f;
    private float negXwall = -138.1482f;
    private float negZwall = -50.16707f;

    public DictionaryClass()
    {
        destinationPoint.Clear();
        environmentDisplacement.Clear();
        environmentDisplacement.Add("", new Vector3[]{new Vector3(0,0,0), new Vector3(0,0,0)});
        //Ground Floor
        environmentDisplacement.Add("GADS",new Vector3[]{new Vector3(4,0,4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("Cashier",new Vector3[]{new Vector3(7,0,-5.5f), new Vector3(negZwall,0,0)});
        environmentDisplacement.Add("Accounting",new Vector3[]{new Vector3(-17.5f,0,-11), new Vector3(negXwall,0,0)});
        environmentDisplacement.Add("Records",new Vector3[]{new Vector3(-17.5f,0,4.5f), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("EDP",new Vector3[]{new Vector3(-21,0,-2), new Vector3(negXwall,0,0)});
        environmentDisplacement.Add("CR",new Vector3[]{new Vector3(20,0,-8), new Vector3(negZwall,0,0)});
        //Mezzanine
        environmentDisplacement.Add("Repair Storage",new Vector3[]{new Vector3(23,1.2f,4), new Vector3(xwall,0,0)});
        environmentDisplacement.Add("M1",new Vector3[]{new Vector3(23,1.2f,4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("M2",new Vector3[]{new Vector3(13,1.2f,4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("M3",new Vector3[]{new Vector3(6,1.2f,4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("M4",new Vector3[]{new Vector3(3.5f,1.2f,4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("Research Hub",new Vector3[]{new Vector3(-15,1.8f,6), new Vector3(xwall,0,0)});
        environmentDisplacement.Add("Focus Office",new Vector3[]{new Vector3(-21,1.8f,6), new Vector3(zwall,0,0)});
        //environmentDisplacement.Add("Focus Office Exit",new Vector3[]{new Vector3(-15,1.8f,6), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("Alumni Office",new Vector3[]{new Vector3(-23,1.8f,6), new Vector3(zwall,0,0)});
        //environmentDisplacement.Add("Alumni Office Exit",new Vector3[]{new Vector3(-28,1.8f,6), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("BMO",new Vector3[]{new Vector3(-20.15f,1.2f,-13), new Vector3(negXwall,0,0)});
        environmentDisplacement.Add("Cisco Entrance",new Vector3[]{new Vector3(19.05f,1.2f,-13), new Vector3(xwall,0,0)});
        environmentDisplacement.Add("Cisco Exit",new Vector3[]{new Vector3(-5.5f,1.2f,-13), new Vector3(negXwall,0,0)});
        environmentDisplacement.Add("C2",new Vector3[]{new Vector3(-3.8f,1.2f,-13), new Vector3(xwall,0,0)});
        //SecondFloor
        environmentDisplacement.Add("HR entrance",new Vector3[]{new Vector3(15.5f,4,-6f), new Vector3(negZwall,0,0)});
        environmentDisplacement.Add("HR",new Vector3[]{new Vector3(7,4,-6f), new Vector3(xwall,0,0)});
        environmentDisplacement.Add("212",new Vector3[]{new Vector3(21.5f,4,4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("212 Exit",new Vector3[]{new Vector3(27.5f,4,4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("211",new Vector3[]{new Vector3(19.5f,4,4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("211 Exit",new Vector3[]{new Vector3(13.5f,4,4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("C1",new Vector3[]{new Vector3(11.5f,4,4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("C1 Exit",new Vector3[]{new Vector3(1,4,4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("Computer Maintenance",new Vector3[]{new Vector3(21.5f,4,4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("208",new Vector3[]{new Vector3(-12.5f,4,4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("208 Exit",new Vector3[]{new Vector3(-6,4,4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("207",new Vector3[]{new Vector3(-14.5f,4,4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("207 Exit",new Vector3[]{new Vector3(-21.2f,4,4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("Dark Room",new Vector3[]{new Vector3(-23,4,4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("Crime Lab",new Vector3[]{new Vector3(-21.5f,4,0.9f), new Vector3(negXwall,0,0)});
        environmentDisplacement.Add("Crime Lab Exit",new Vector3[]{new Vector3(-21.5f,4,-6), new Vector3(negXwall,0,0)});
        environmentDisplacement.Add("Girls CR 2ndFloor",new Vector3[]{new Vector3(-21.5f,4,-9.5f), new Vector3(negXwall,0,0)});
        environmentDisplacement.Add("Speech Lab",new Vector3[]{new Vector3(-16.5f,4,-6), new Vector3(negZwall,0,0)});
        environmentDisplacement.Add("Speech Lab Exit",new Vector3[]{new Vector3(-5f,4,-6), new Vector3(negZwall,0,0)});
        environmentDisplacement.Add("Criminology Intern Office",new Vector3[]{new Vector3(0.5f,4,-8.25f), new Vector3(negXwall,0,0)});
        environmentDisplacement.Add("Criminology Intern Office Exit",new Vector3[]{new Vector3(0.5f,4,-12), new Vector3(negXwall,0,0)});
        environmentDisplacement.Add("Scholarship Office",new Vector3[]{new Vector3(4,4,-6f), new Vector3(negZwall,0,0)});
        //ThirdFloor
        environmentDisplacement.Add("312", new Vector3[]{new Vector3(20.5f,8,4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("312 Exit", new Vector3[]{new Vector3(27.5f,8,4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("C4", new Vector3[]{new Vector3(18.5f, 8, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("C4 Exit", new Vector3[]{new Vector3(4, 8, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("309", new Vector3[]{new Vector3(1.5f, 8, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("309 Exit", new Vector3[]{new Vector3(-4.5f, 8, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("308", new Vector3[]{new Vector3(-6, 8, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("308 Exit", new Vector3[]{new Vector3(-12.5f, 8, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("307", new Vector3[]{new Vector3(-14.5f, 8, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("307 Exit", new Vector3[]{new Vector3(-21, 8, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("306", new Vector3[]{new Vector3(-23, 8, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("305", new Vector3[]{new Vector3(-21.2f, 8, 0.8f), new Vector3(negXwall,0,0)});
        environmentDisplacement.Add("305 Exit", new Vector3[]{new Vector3(-21.2f, 8, -4), new Vector3(negXwall,0,0)});
        environmentDisplacement.Add("Girls CR 3rdFloor", new Vector3[]{new Vector3(-21.2f, 8, -8), new Vector3(negXwall,0,0)});
        environmentDisplacement.Add("Satellite Clinic", new Vector3[]{new Vector3(-14, 8, -5.5f), new Vector3(negZwall,0,0)});
        environmentDisplacement.Add("Elderly", new Vector3[]{new Vector3(-9, 8, -5.5f), new Vector3(negZwall,0,0)});
        environmentDisplacement.Add("Elderly Exit", new Vector3[]{new Vector3(-1.25f, 8, -5.5f), new Vector3(negZwall,0,0)});
        environmentDisplacement.Add("Nursing Faculty", new Vector3[]{new Vector3(8.75f, 8, -5.5f), new Vector3(negZwall,0,0)});
        environmentDisplacement.Add("Nursing Faculty Exit", new Vector3[]{new Vector3(1.45f, 8, -7.5f), new Vector3(xwall,0,0)});
        //Fourth FLoor
        environmentDisplacement.Add("Skills Lab", new Vector3[]{new Vector3(5, 11.8f, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("Skills Lab Exit", new Vector3[]{new Vector3(26, 11.8f, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("Ampitheater", new Vector3[]{new Vector3(2, 11.8f, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("Classroom 1", new Vector3[]{new Vector3(-8, 11.8f, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("Anatomy Lab", new Vector3[]{new Vector3(-10, 11.8f, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("Anatomy Lab Exit", new Vector3[]{new Vector3(-21, 11.8f, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("CADS", new Vector3[]{new Vector3(-23.5f, 11.8f, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("OPD ER", new Vector3[]{new Vector3(-20.8f, 11.8f, 1), new Vector3(negXwall,0,0)});
        environmentDisplacement.Add("OPD ER Exit", new Vector3[]{new Vector3(-20.8f, 11.8f, -5.5f), new Vector3(negXwall,0,0)});
        environmentDisplacement.Add("Girls CR 4thFloor", new Vector3[]{new Vector3(-20.8f, 11.8f, -8), new Vector3(negXwall,0,0)});
        environmentDisplacement.Add("Kitchen Lab", new Vector3[]{new Vector3(-11, 11.8f, -5.5f), new Vector3(negZwall,0,0)});
        environmentDisplacement.Add("Cold Kitchen", new Vector3[]{new Vector3(-1.5f, 11.8f, -5.5f), new Vector3(negZwall,0,0)});
        environmentDisplacement.Add("Cold Kitchen Exit", new Vector3[]{new Vector3(0.75f, 11.8f, -11.5f), new Vector3(negZwall,0,0)});
        environmentDisplacement.Add("HRM Mini Resto", new Vector3[]{new Vector3(10f, 11.8f, -5.5f), new Vector3(negZwall,0,0)});
        environmentDisplacement.Add("HRM Mini Resto Exit", new Vector3[]{new Vector3(15, 11.8f, -5.5f), new Vector3(negZwall,0,0)});
        //Fifth Floor
        environmentDisplacement.Add("Preparation Room", new Vector3[]{new Vector3(25, 16, 4), new Vector3(xwall,0,0)});
        environmentDisplacement.Add("Chem Lab 511", new Vector3[]{new Vector3(25, 16, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("Chem Lab 511 Exit", new Vector3[]{new Vector3(19, 16, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("Chem Stockroom", new Vector3[]{new Vector3(15.5f, 16, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("Chem Lab 509", new Vector3[]{new Vector3(11.5f, 16, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("Chem Lab 509 Exit", new Vector3[]{new Vector3(1.3f, 16, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("Physics Stockroom", new Vector3[]{new Vector3(-2.5f, 16, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("Physics Lab Exit", new Vector3[]{new Vector3(-6, 16, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("Physics Lab", new Vector3[]{new Vector3(-15.5f, 16, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("Engineering Faculty", new Vector3[]{new Vector3(-18.5f, 16, 4), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("Biology Lab", new Vector3[]{new Vector3(-21, 16, 1), new Vector3(negXwall,0,0)});
        environmentDisplacement.Add("Biology Lab Exit", new Vector3[]{new Vector3(-21, 16, -4), new Vector3(negXwall,0,0)});
        environmentDisplacement.Add("Girls CR 5thFloor", new Vector3[]{new Vector3(-21, 16, -8), new Vector3(zwall,0,0)});
        environmentDisplacement.Add("COE", new Vector3[]{new Vector3(-10.5f, 16, -5.5f), new Vector3(negZwall,0,0)});
        environmentDisplacement.Add("ECE", new Vector3[]{new Vector3(-8f, 16, -5.5f), new Vector3(negZwall,0,0)});
        environmentDisplacement.Add("Tool Room", new Vector3[]{new Vector3(5, 16, -5.5f), new Vector3(negZwall,0,0)});
        environmentDisplacement.Add("501", new Vector3[]{new Vector3(15, 16, -5.5f), new Vector3(negZwall,0,0)});
        environmentDisplacement.Add("501 Exit", new Vector3[]{new Vector3(9, 16, -5.5f), new Vector3(negZwall,0,0)});
        ///<<===========================================================Map Destination Point==========================================================================>>
        /****************************************************************************************************************************************************************/
        destinationPoint.Add("",new Vector3(10,0,0));
        //Ground Floor
        destinationPoint.Add("Cashier", new Vector3(8, 0, -5.5f));
        destinationPoint.Add("Accounting", new Vector3(-17.5f, 0, -11));
        destinationPoint.Add("Records", new Vector3(-14,0,4.5f));
        destinationPoint.Add("EDP", new Vector3(-21,0,-1.5f));
        destinationPoint.Add("CR", new Vector3(20,0,-8));
        destinationPoint.Add("GADS", new Vector3(6,0,1.8f));
        //Mezzanine
        destinationPoint.Add("Repair Storage", new Vector3(25, 1.2f, 4));
        destinationPoint.Add("C2", new Vector3(-2.5f,1.2f,-13.08f));
        destinationPoint.Add("Cisco Entrance", new Vector3(-18f, 1.2f, -13.08f));
        destinationPoint.Add("Cisco Exit", new Vector3(-5.8f, 1.2f, -13.08f));
        destinationPoint.Add("BMO", new Vector3(-22, 1.2f, -13.08f));
        destinationPoint.Add("M1", new Vector3(23.5f, 1.2f, 4));//z = 3.5f
        destinationPoint.Add("M2", new Vector3(15, 1.2f, 4));//z = 3.5f
        destinationPoint.Add("M3", new Vector3(10, 1.2f, 4));//z = 3.5f
        destinationPoint.Add("M4", new Vector3(3, 1.2f, 4));//z = 3.5f
        destinationPoint.Add("Research Hub", new Vector3(-15, 1.8f, 6.4f));//z = 6.4f
        destinationPoint.Add("Focus Office", new Vector3(-20, 1.8f, 6.4f));
        destinationPoint.Add("Alumni Room", new Vector3(-27, 1.8f, 6.4f));
        //2ndFloor
        destinationPoint.Add("HR", new Vector3(7,4,-5.5f));
        destinationPoint.Add("HR entrance", new Vector3(15.5f,4,-5.5f));
        destinationPoint.Add("Scholarship Office", new Vector3(4, 4, -5.5f));
        destinationPoint.Add("Criminology Intern Room", new Vector3(1, 4, -10.5f));
        destinationPoint.Add("Speech Laboratory", new Vector3(-11, 4, -5.5f));
        destinationPoint.Add("Girls CR_2nd", new Vector3(-21, 4, -9));
        destinationPoint.Add("Crime Lab", new Vector3(-21, 4, -2.5f));
        destinationPoint.Add("Dark Room", new Vector3(-22, 4, 3.5f));
        destinationPoint.Add("207", new Vector3(-18, 4, 3.5f));
        destinationPoint.Add("208", new Vector3(-9, 4, 3.5f));
        destinationPoint.Add("Computer Maintenance", new Vector3(-2.5f, 4, 3.5f));
        destinationPoint.Add("C1", new Vector3(6.3f, 4, 3.5f));
        destinationPoint.Add("211", new Vector3(17, 4, 3.5f));
        destinationPoint.Add("212", new Vector3(25, 4, 3.5f));
        //3rdFloor
        destinationPoint.Add("312", new Vector3(24,8,3.5f));
        destinationPoint.Add("C4", new Vector3(12.5f, 8, 3.5f));
        destinationPoint.Add("309", new Vector3(-1.5f, 8, 3.5f));
        destinationPoint.Add("308", new Vector3(-9.5f, 8, 3.5f));
        destinationPoint.Add("307", new Vector3(-17.5f, 8, 3.5f));
        destinationPoint.Add("306", new Vector3(-23.5f, 8, 3.5f));
        destinationPoint.Add("305", new Vector3(-20.8f,8,-2));
        destinationPoint.Add("Girls CR_3rd", new Vector3(-20.8f,8,-7.7f));
        //destinationPoint.Add("Nursing Consultation", new Vector3(-20.8f, 8, -9.5f));
        destinationPoint.Add("Satellite Clinic", new Vector3(-13,8,-5.5f));
        destinationPoint.Add("Nursing Elderly", new Vector3(-4.5f,8,-5.5f));
        destinationPoint.Add("Nursing Faculty", new Vector3(10.5f,8,-5.5f));
        //4th Floor
        destinationPoint.Add("Skills Laboratory", new Vector3(20,11.8f,3.5f));
        destinationPoint.Add("Amphitheater", new Vector3(-2.5f, 11.8f, 3.5f));
        destinationPoint.Add("Anatomy Lab", new Vector3(-15, 11.8f, 3.5f));
        destinationPoint.Add("CAD's Office", new Vector3(-23.5f, 11.8f, 3.5f));
        destinationPoint.Add("OPD_ER", new Vector3(-20.8f,11.8f,-2));
        destinationPoint.Add("Girls CR_4th", new Vector3(-20.8f, 11.8f, -7.7f));
        destinationPoint.Add("Kitchen Lab", new Vector3(-12,11.8f,-5.5f));
        destinationPoint.Add("Cold Kitchen", new Vector3(-2.3f, 11.8f, -5.5f));
        destinationPoint.Add("HRM MiniResto", new Vector3(-10, 11.8f, -5.5f));
        //5th Floor
        destinationPoint.Add("EE Lab", new Vector3(13,16, -5.5f));
        destinationPoint.Add("Tool Room", new Vector3(5, 16, -5.5f));
        destinationPoint.Add("ECE", new Vector3(-4.5f, 16, -5.5f));
        destinationPoint.Add("COE", new Vector3(-13, 16, -5.5f));
        destinationPoint.Add("Girls CR_5th", new Vector3(-20.8f, 16, -7.7f));
        destinationPoint.Add("Biology", new Vector3(-20.8f, 16, -2));
        destinationPoint.Add("Faculty", new Vector3(-20, 16, 3.5f));
        destinationPoint.Add("507", new Vector3(10.5f, 16, 3.5f));
        destinationPoint.Add("509", new Vector3(6, 16, 3.5f));
        destinationPoint.Add("511", new Vector3(20, 16, 3.5f));

    }
}
