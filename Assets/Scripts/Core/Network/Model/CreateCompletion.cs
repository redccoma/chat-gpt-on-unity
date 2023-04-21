using System;
using Newtonsoft.Json;

[Serializable]
public class CreateCompletion
{
    [Serializable]
    public class Request
    {
        /// <summary>
        /// string. Required.
        /// 사용할 모델의 ID입니다. 모델 목록 API를 사용하여 사용 가능한 모든 모델을 보거나 모델 개요에서 설명을 볼 수 있습니다.
        /// </summary>
        public string model;

        /// <summary>
        /// string or array. Optional. Defaults to<|endoftext|>
        /// 문자열, 문자열 배열, 토큰 배열 또는 토큰 배열 배열로 인코딩된 완성을 생성하는 프롬프트입니다.
        /// <|endoftext|>는 훈련 중에 모델이 보는 문서 구분 기호이므로 프롬프트가 지정되지 않으면 모델이 새 문서의 시작 부분에서 생성되는 것처럼 생성됩니다.
        /// </summary>
        public string prompt;

        /// <summary>
        /// string. Optional. Defaults to null.
        /// </summary>
        public string suffix;
    }

    [Serializable]
    public class Response
    {

    }
}
