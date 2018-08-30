using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour {
    public GameObject[] prefabslot;

	// Use this for initialization
	void Start () {
        createOutline();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void create(GameObject prefab, float x, float y, float z, int rotX, int rotY, int rotZ)
    {
        Instantiate(prefab, new Vector3(x,y,z),Quaternion.Euler((float)rotX, (float)rotY, (float)rotZ));
    }

    public void createOutline()
    {
        //kantoor
        for (var i = 0; i < 6; i++)
        {
            create(prefabslot[0], i, 1, 0.125f, 0, 0, 0);
        }

        for (var i = 0; i < 10; i++)
        {
            create(prefabslot[0], -0.625f, 1, i + 0.75f, 0, 90, 0);
        }

        for (var i = 0; i < 6; i++)
        {
            create(prefabslot[0], i, 1, 10.375f, 0, 180, 0);
        }

        for (var i = 0; i < 10; i++)
        {
            create(prefabslot[0], 5.5f, 1, i + 0.75f, 0, 270, 0);
        }

        //garderobe
        for (var i = 0; i < 6; i++)
        {
            create(prefabslot[0], -0.125f, 1, i - 5.5f, 0, 90, 0);
        }

        for (var i = 0; i < 5; i++)
        {
            create(prefabslot[0], i + 0.5f, 1, -3.125f, 0, 180, 0);
        }

        for (var i = 0; i < 6; i++)
        {
            create(prefabslot[0], 5.125f, 1, i - 5.5f, 0, 270, 0);
        }

        //relax
        for (var i = 0; i < 4; i++)
        {
            create(prefabslot[0], i + 5.75f, 1, 0.125f, 0, 180, 0);
        }

        for (var i = 0; i < 6; i++)
        {
            create(prefabslot[0], 9.375f, 1, i - 5.5f, 0, 270, 0);
        }

        for (var i = 0; i < 4; i++)
        {
            create(prefabslot[0], i + 5.75f, 1, 0-6.125f, 0, 180, 0);
        }

        //trap bg
        for (var i = 0; i < 4; i++)
        {
            create(prefabslot[0], i- 3.75f, 1, 0.125f, 0, 180, 0);
        }

        for (var i = 0; i < 6; i++)
        {
            create(prefabslot[0], -4.375f, 1, i - 5.5f, 0, 270, 0);
        }

        for (var i = 0; i < 4; i++)
        {
            create(prefabslot[0], i- 3.75f, 1, 0 - 6.125f, 0, 180, 0);
        }
    }
}
