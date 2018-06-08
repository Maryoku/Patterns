using System;
using System.Collections.Generic;

namespace Patterns.Ex01
{
    //Стратегия
    public interface SocialNetworkStrategy
    {
        SocialNetworkUser[] GetSubscribers();
    }

    public class SubscriberViewer
    {
        /// <summary>
        /// Возвращает список подписчиков пользователя из соц.сети.
        /// TODO: необходимо изменить этот метод по условиям задачи
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