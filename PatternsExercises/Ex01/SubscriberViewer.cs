using System;
using System.Collections.Generic;

namespace Patterns.Ex01
{
    //���������
    public interface SocialNetworkStrategy
    {
        SocialNetworkUser[] GetSubscribers();
    }

    public class SubscriberViewer
    {
        /// <summary>
        /// ���������� ������ ����������� ������������ �� ���.����.
        /// TODO: ���������� �������� ���� ����� �� �������� ������
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="networkType"></param>
        /// <returns></returns>

        public Dictionary<SocialNetwork, SocialNetworkStrategy> dictionary;

        public SocialNetworkUser[] GetSubscribers(String userName, SocialNetwork networkType)
        {
            return dictionary[networkType].GetSubscribers();
            
            //TODO?
            //return null;
        }
    }
}