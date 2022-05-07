using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System;
using UnityEngine;
using DG.Tweening;
//using UnityEditor;

public class PathExporter : MonoBehaviour
{
    private List<Dictionary<string, object>> wayNameList;
    private List<Dictionary<string, object>> wayPointsList;
    private List<Vector3> points = new List<Vector3>();

    public void ExportToJson()
    {
        var allDoTweenPath = transform.GetComponentsInChildren<DOTweenPath>();
        wayNameList = new List<Dictionary<string, object>>();
        wayPointsList = new List<Dictionary<string, object>>();
        for (int i = 0; i < allDoTweenPath.Length; i++)
        {
            var dtp = allDoTweenPath[i];
            var wps = new List<int[]>();
            dtp.wps.ForEach((point) => { wps.Add(new List<int>() { (int)point.x, (int)point.y, (int)point.z }.ToArray()); });
            wps.Insert(0, new List<int>() { (int)dtp.transform.position.x, (int)dtp.transform.position.y, (int)dtp.transform.position.z }.ToArray());
            if (dtp.isClosedPath) wps.Add(new List<int>() { (int)dtp.transform.position.x, (int)dtp.transform.position.y, (int)dtp.transform.position.z }.ToArray());
            //var length = CalculatePathLength(wps);
            wayNameList.Add(new Dictionary<string, object>()
            {
                {"Id",i+1},{"name",dtp.name}
            });
//             wayPointsList.Add(new Dictionary<string, object>()
//             {
//                 {"Id",i+1},{"key",dtp.name},{"length",CalculatePathLength(wps)},{"points",JsonConvert.SerializeObject(wps.ToArray())}
//             });
        }
        exportToJson();
    }

    private void exportToJson()
    {
//         FileStream fileStream = new FileStream(Application.dataPath + "/Editor/PathEditor/PathName.json", FileMode.OpenOrCreate);
//         StreamWriter streamWriter = new StreamWriter(fileStream);
//         streamWriter.WriteLine(JsonConvert.SerializeObject(wayNameList));
//         streamWriter.Close();
//         fileStream.Close();
//         fileStream.Dispose();
// 
//         fileStream = new FileStream(Application.dataPath + "/Editor/PathEditor/PathWayPoints.json", FileMode.OpenOrCreate);
//         streamWriter = new StreamWriter(fileStream);
//         streamWriter.WriteLine(JsonConvert.SerializeObject(wayPointsList));
//         streamWriter.Close();
//         fileStream.Close();
//         fileStream.Dispose();

        //AssetDatabase.Refresh();
    }

    public void ExportToLua()
    {
        var allDoTweenPath = transform.GetComponentsInChildren<DOTweenPath>();
        wayNameList = new List<Dictionary<string, object>>();
        wayPointsList = new List<Dictionary<string, object>>();
        for (int i = 0; i < allDoTweenPath.Length; i++)
        {
            var dtp = allDoTweenPath[i];
            var wps = new List<int[]>();
            dtp.wps.ForEach((point) => { wps.Add(new List<int>() { (int)point.x, (int)point.y, (int)point.z }.ToArray()); });
            wps.Insert(0, new List<int>() { (int)dtp.transform.position.x, (int)dtp.transform.position.y, (int)dtp.transform.position.z }.ToArray());
            if (dtp.isClosedPath) wps.Add(new List<int>() { (int)dtp.transform.position.x, (int)dtp.transform.position.y, (int)dtp.transform.position.z }.ToArray());
            //var length = CalculatePathLength(wps);
            wayNameList.Add(new Dictionary<string, object>()
            {
                {"Id",i+1},{"name",dtp.name}
            });
//             wayPointsList.Add(new Dictionary<string, object>()
//             {
//                 {"Id",i+1},{"key",dtp.name},{"length",CalculatePathLength(wps)},{"points",JsonConvert.SerializeObject(wps.ToArray())}
//             });
        }
        exportToLua();
    }

    private void exportToLua()
    {
        var wayNameStr = "return{\n";
        for (int i = 0; i < wayNameList.Count; i++)
        {
            wayNameStr += $"[{i + 1}]=" + "{";
            wayNameStr += $"Id={i + 1},";
            wayNameStr += $"name=\"{wayNameList[i]["name"]}\"";
            wayNameStr += "},\n";
        }
        wayNameStr += "}";

        FileStream fileStream = new FileStream(Application.dataPath + "/Editor/PathEditor/PathName.lua", FileMode.OpenOrCreate);
        StreamWriter streamWriter = new StreamWriter(fileStream);
        streamWriter.WriteLine(wayNameStr);
        streamWriter.Close();
        fileStream.Close();
        fileStream.Dispose();

        var wayPointStr = "return{\n";
        for (int i = 0; i < wayPointsList.Count; i++)
        {
            wayPointStr += $"[\"{wayPointsList[i]["key"]}\"]=" + "{";
            wayPointStr += $"length={wayPointsList[i]["length"]},";
            wayPointStr += $"points=\"{wayPointsList[i]["points"]}\",";
            wayPointStr += "},\n";
        }
        wayPointStr += "}";

        fileStream = new FileStream(Application.dataPath + "/Editor/PathEditor/PathWayPoints.lua", FileMode.OpenOrCreate);
        streamWriter = new StreamWriter(fileStream);
        streamWriter.WriteLine(wayPointStr);
        streamWriter.Close();
        fileStream.Close();
        fileStream.Dispose();
    }

    private float CalculatePathLength(List<int[]> wps)
    {
        float length = 0;
        var path = new List<Vector3>();
        wps.ForEach((wp) => { path.Add(new Vector3(wp[0], wp[1], wp[2])); });
        CreateCurvePath(path);
        for (int i = 0; i < 10000; i++)
        {
            length += Vector3.Distance(GetCurveInterPoint(i / 10000), GetCurveInterPoint((i + 1) / 10000));
        }
        return length;
    }

    private void CreateCurvePath(List<Vector3> path)
    {
        points.Clear();
        points.Add(path[0]);
        for (int i = 0; i < path.Count; i++)
        {
            points.Add(path[i]);
        }
        points.Add(path[path.Count - 1]);
    }

    private Vector3 GetCurveInterPoint(float time)
    {
        int numSections = points.Count - 3;
        int cur = Mathf.Min(Mathf.FloorToInt(time * numSections), numSections - 1);
        float u = time * numSections - cur;
        Vector3 a = points[cur];
        Vector3 b = points[cur + 1];
        Vector3 c = points[cur + 2];
        Vector3 d = points[cur + 3];
        return new Vector3(CalculatePosition(a.x, b.x, c.x, d.x, u), CalculatePosition(a.y, b.y, c.y, d.y, u), CalculatePosition(a.z, b.z, c.z, d.z, u));
    }

    private float CalculatePosition(float a, float b, float c, float d, float u)
    {
        return 0.5f * ((-a + 3 * b - 3 * c + d) * (u * u * u) + (2 * a - 5 * b + 4 * c - d) * (u * u) + (-a + c) * u + 2 * b);
    }

    public void ExportToExcel()
    {
        ExportToJson();

        var exePath = Application.dataPath + "/Editor/PathEditor/PathEditorExcelConverter.exe";
        System.Diagnostics.Process.Start(exePath);
    }
}
