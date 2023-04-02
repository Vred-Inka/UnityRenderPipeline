using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CameraRenderer { 
    ScriptableRenderContext mContext;
    Camera mCamera;

    public void Render (ScriptableRenderContext context, Camera camera) {
        mContext = context;
        mCamera = camera;

        Setup();
        DrawVisibleGeometry();
        Submit();
    }

    void Setup() {
        mContext.SetupCameraProperties(mCamera);
    }

    void DrawVisibleGeometry() {
        mContext.DrawSkybox(mCamera);
    }

    void Submit() {
        mContext.Submit();
    }
}
