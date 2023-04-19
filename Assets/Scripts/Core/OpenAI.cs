/// <summary>
/// https://platform.openai.com/docs/api-reference 기능들
/// </summary>
public static class OpenAI
{
    /// <summary>
    /// 현재 사용 가능한 모델을 나열하고 소유자 및 가용성과 같은 각 모델에 대한 기본 정보를 제공합니다.
    /// </summary>
    private static readonly string GET_LIST_MODEL = "https://api.openai.com/v1/models";
    /// <summary>
    /// 소유자 및 권한과 같은 모델에 대한 기본 정보를 제공하는 모델 인스턴스를 검색합니다.
    /// </summary>
    private static readonly string GET_RETRIEVE_MODEL = "https://api.openai.com/v1/models/{0}";
    /// <summary>
    /// 제공된 프롬프트 및 매개변수에 대한 완성을 생성합니다.
    /// </summary>
    private static readonly string POST_CREATE_COMPLETION = "https://api.openai.com/v1/completions";
}
