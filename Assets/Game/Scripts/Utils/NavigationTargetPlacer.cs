using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationTargetPlacer : MonoBehaviour
{
   public float placeRadius;

   public Transform target;

   public void RandomPlace()
   {
      var x = Random.Range(0f, placeRadius);
      var y = Mathf.Sqrt(placeRadius * placeRadius - x * x);

      int seg = Random.Range(1, 4);
      switch (seg)
      {
         case 2:
            x = -x;
            break;
         case 3:
            x = -x;
            y = -y;
            break;
         case 4:
            y = -y;
            break;
      }

      target.position = transform.position + new Vector3(x, y);
   }
}
