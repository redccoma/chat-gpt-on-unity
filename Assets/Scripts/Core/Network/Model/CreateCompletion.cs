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
        /// ����� ���� ID�Դϴ�. �� ��� API�� ����Ͽ� ��� ������ ��� ���� ���ų� �� ���信�� ������ �� �� �ֽ��ϴ�.
        /// </summary>
        public string model;

        /// <summary>
        /// string or array. Optional. Defaults to<|endoftext|>
        /// ���ڿ�, ���ڿ� �迭, ��ū �迭 �Ǵ� ��ū �迭 �迭�� ���ڵ��� �ϼ��� �����ϴ� ������Ʈ�Դϴ�.
        /// <|endoftext|>�� �Ʒ� �߿� ���� ���� ���� ���� ��ȣ�̹Ƿ� ������Ʈ�� �������� ������ ���� �� ������ ���� �κп��� �����Ǵ� ��ó�� �����˴ϴ�.
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
