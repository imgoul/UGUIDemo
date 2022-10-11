using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;
using UnityEngine.UI;

public class CircleImage : Image
{
    /// <summary>
    /// 圆形由多少块三角形拼成
    /// </summary>
    [SerializeField] public int fragmentCount = 100;

    protected override void OnPopulateMesh(VertexHelper vh)
    {
        vh.Clear();
        AddVertex(vh);
    }


    private void AddVertex(VertexHelper vh)
    {
        //获取rectTransform宽高
        float width = rectTransform.rect.width;
        float height = rectTransform.rect.height;

        //获取精灵uv信息
        Vector4 uv = sprite != null ? DataUtility.GetOuterUV(overrideSprite) : Vector4.zero;
        float uvWidth = uv.z - uv.x;
        float uvHeight = uv.w - uv.y;
        // 获取uv中心点的坐标
        Vector2 uvCenter = new Vector2(uvWidth * 0.5f, uvHeight * 0.5f);
        Vector2 convertRatio = new Vector2(uvWidth / width, uvHeight / height);


        float radian = (2 * Mathf.PI) / fragmentCount;
        float radius = width * 0.5f;


        UIVertex origin = new UIVertex();
        origin.color = color;


        //圆点中心点在RectTransform中的位置
        Vector2 originPos =
            new Vector2((0.5f - rectTransform.pivot.x) * width, (0.5f - rectTransform.pivot.y) * height);
        // 顶点在RectTransform中的位置
        origin.position = originPos;//相对于pivot的坐标
        //uv坐标信息映射注意事项： 1.RectTransform和UV的中心点要一致   2.RectTransform的坐标*单位换算系数
        origin.uv0 = new Vector4(uvCenter.x, uvCenter.y);
        vh.AddVert(origin);

        int vertexCount = fragmentCount + 1;
        float curRadian = 0;
        for (int i = 0; i < vertexCount; i++)
        {
            float x = Mathf.Cos(curRadian) * radius;
            float y = Mathf.Sin(curRadian) * radius;
            curRadian += radian;

            UIVertex vertex = new UIVertex();
            vertex.color = color;
            vertex.position = new Vector3(x + originPos.x, y + originPos.y);
            vertex.uv0 = new Vector4(x * convertRatio.x + uvCenter.x, y * convertRatio.y + uvCenter.y);
            vh.AddVert(vertex);
        }


        int vertexIdx = 1;
        for (int i = 0; i < fragmentCount; i++)
        {
            vh.AddTriangle(vertexIdx, 0, vertexIdx + 1);
            vertexIdx++;
        }
    }

    /*public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
    {
        
    }*/


}