﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLab
{
    public class DataDump
    {
        public int productCount = 31;

        static JsonProduct[] allProducts = {
            new JsonProduct {
                id = 1,
                category_id = 6,
                title = "Casio MRP-700-1AVEF",
                alias = "casio-mrp-700-1avef",
                content = null,
                price = 300,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "p-1.png",
                hit = 1,
                cat = "Casio"
            },
            new JsonProduct {
                id = 2,
                category_id = 6,
                title = "Casio MQ-24-7BUL",
                alias = "casio-mq-24-7bul",
                content = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam tristique, diam in consequat iaculis, est purus iaculis mauris, imperdiet facilisis ante ligula at nulla. Quisque volutpat nulla risus, id maximus ex aliquet ut. Suspendisse potenti. Nulla varius lectus id turpis dignissim porta. Quisque magna arcu, blandit quis felis vehicula, feugiat gravida diam. Nullam nec turpis ligula. Aliquam quis blandit elit, ac sodales nisl. Aliquam eget dolor eget elit malesuada aliquet. In varius lorem lorem, semper bibendum lectus lobortis ac.</p>\n\n                                            <p>Mauris placerat vitae lorem gravida viverra. Mauris in fringilla ex. Nulla facilisi. Etiam scelerisque tincidunt quam facilisis lobortis. In malesuada pulvinar neque a consectetur. Nunc aliquam gravida purus, non malesuada sem accumsan in. Morbi vel sodales libero.</p>",
                price = 70,
                old_price = 80,
                status = 1,
                keywords = null,
                description = null,
                img = "p-2.png",
                hit = 2,
                cat = "Casio"
            },
            new JsonProduct {
                id =3,
                category_id = 6,
                title = "Casio GA-1000-1AER",
                alias = "casio-ga-1000-1aer-3",
                content = "",
                price = 400,
                old_price = 0,
                status = 1,
                keywords = "",
                description = "",
                img = "p-3.png",
                hit = 1,
                cat = "Casio"
            },
            new JsonProduct {
                id = 4,
                category_id = 7,
                title = "Citizen JP1010-00E",
                alias = "citizen-jp1010-00e",
                content = null,
                price = 400,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "p-4.png",
                hit = 2,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 5,
                category_id =7,
                title = "Citizen BJ2111-08E",
                alias = "citizen-bj2111-08e",
                content = null,
                price = 500,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "p-5.png",
                hit = 2,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 6,
                category_id = 7,
                title = "Citizen AT0696-59E",
                alias = "citizen-at0696-59e",
                content = null,
                price = 350,
                old_price = 355,
                status = 1,
                keywords = null,
                description = null,
                img = "p-6.png",
                hit = 2,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 7,
                category_id = 6,
                title = "Q&Q Q956J302Y",
                alias = "q-and-q-q956j302y",
                content = null,
                price = 20,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "p-7.png",
                hit = 2,
                cat = "Casio"
            },
            new JsonProduct {
                id = 8,
                category_id = 8,
                title = "Royal London 41040-01",
                alias = "royal-london-41040-01",
                content = null,
                price = 90,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "p-8.png",
                hit = 2,
                cat = "Royal London"
            },
            new JsonProduct {
                id = 9,
                category_id = 6,
                title = "Royal London 20034-02",
                alias = "royal-london-20034-02",
                content = null,
                price = 110,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 1,
                cat = "Casio"
            },
            new JsonProduct {
                id = 10,
                category_id = 6,
                title = "Royal London 41156-02",
                alias = "royal-london-41156-02",
                content = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam tristique, diam in consequat iaculis, est purus iaculis mauris, imperdiet facilisis ante ligula at nulla. Quisque volutpat nulla risus, id maximus ex aliquet ut. Suspendisse potenti. Nulla varius lectus id turpis dignissim porta. Quisque magna arcu, blandit quis felis vehicula, feugiat gravida diam. Nullam nec turpis ligula. Aliquam quis blandit elit, ac sodales nisl. Aliquam eget dolor eget elit malesuada aliquet. In varius lorem lorem, semper bibendum lectus lobortis ac.</p>\n\n                                            <p>Mauris placerat vitae lorem gravida viverra. Mauris in fringilla ex. Nulla facilisi. Etiam scelerisque tincidunt quam facilisis lobortis. In malesuada pulvinar neque a consectetur. Nunc aliquam gravida purus, non malesuada sem accumsan in. Morbi vel sodales libero.</p>",
                price = 100,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 2,
                cat = "Casio"
            },
            new JsonProduct {
                id = 12,
                category_id = 7,
                title = "Часы 1",
                alias = "chasy-1",
                content = null,
                price = 100,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 1,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 13,
                category_id = 7,
                title = "Часы 2",
                alias = "chasy-2",
                content = null,
                price = 105,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 1,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 14,
                category_id = 7,
                title = "Часы 3",
                alias = "chasy-3",
                content = null,
                price = 110,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 1,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 15,
                category_id = 7,
                title = "Часы 4",
                alias = "chasy-4",
                content = null,
                price = 115,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 1,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 16,
                category_id = 7,
                title = "Часы 5",
                alias = "chasy-5",
                content = null,
                price = 115,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 1,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 17,
                category_id = 7,
                title = "Часы 6",
                alias = "chasy-6",
                content = null,
                price = 120,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 1,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 20,
                category_id = 7,
                title = "Часы 7",
                alias = "chasy-7",
                content = null,
                price = 120,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 1,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 21,
                category_id = 7,
                title = "Часы 8",
                alias = "chasy-8",
                content = null,
                price = 120,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 1,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 22,
                category_id = 7,
                title = "Часы 9",
                alias = "chasy-9",
                content = null,
                price = 125,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 1,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 23,
                category_id = 7,
                title = "Часы 10",
                alias = "chasy-10",
                content = null,
                price = 125,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 1,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 24,
                category_id = 7,
                title = "Часы 11",
                alias = "chasy-11",
                content = null,
                price = 125,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 1,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 25,
                category_id = 7,
                title = "Часы 12",
                alias = "chasy-12",
                content = null,
                price = 125,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 1,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 26,
                category_id = 7,
                title = "Часы 13",
                alias = "chasy-13",
                content = null,
                price = 125,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 1,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 27,
                category_id = 7,
                title = "Часы 14",
                alias = "chasy-14",
                content = null,
                price = 125,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 1,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 28,
                category_id = 7,
                title = "Часы 15",
                alias = "chasy-15",
                content = null,
                price = 125,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 1,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 29,
                category_id = 7,
                title = "Часы 16",
                alias = "chasy-16",
                content = null,
                price = 125,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 1,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 30,
                category_id = 7,
                title = "Часы 17",
                alias = "chasy-17",
                content = null,
                price = 125,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 1,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 31,
                category_id = 7,
                title = "Часы 18",
                alias = "chasy-18",
                content = null,
                price = 125,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 1,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 32,
                category_id = 7,
                title = "Часы 19",
                alias = "chasy-19",
                content = null,
                price = 125,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 1,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 33,
                category_id = 7,
                title = "Часы 20",
                alias = "chasy-20",
                content = null,
                price = 125,
                old_price = 0,
                status = 1,
                keywords = null,
                description = null,
                img = "no_image.jpg",
                hit = 1,
                cat = "Citizen"
            },
            new JsonProduct {
                id = 48,
                category_id = 11,
                title = "TAG Heuer SBF818001.11FT8031",
                alias = "tag-heuer-sbf818001-11ft8031-48",
                content = "<p>Швейцарские смарт-часы в проверенном качестве с модульной концепцией - уникальный образец современных технологий на вашем запястье.</p>\r\n\r\n<p>&nbsp;</p>\r\n\r\n<p><strong>Connected Modular.</strong> Смарт-часы. Унисекс. Совместимость: смартфоны на базе Android&trade; 4.4 или выше, iPhone 5 или выше на базе iOS 9+ или выше. Операционная система Android Wear. Процессор Intel Atom. Оперативная память 1GB, встроенная память 8GB. Сенсорный дисплей: AMOLED, диагональ 1,2&#39;&#39; (30,4мм). Подключения: USB 2.0, Bluetooth 4.1, Wi-Fi 802,11 b/g/n (2.4 ГГц). Система навигации - GPS. Датчики: акселерометр, гироскоп, датчик наклона, микрофон, технология вибрационного/тактильного отклика, датчик внешней освещенности, система оплаты NFC. Емкость аккумулятора 345 мА*ч, использование в обычном режиме 25 часов, время зарядки полностью разряженной батареи - 1 час 50 минут. Подключение: Bluetooth BLE 4.1, WiFi 2,4 ГГц 802.11 B/G/N. Специальное приложение для смартфонов, делающее возможным взаимодействие с часами TAG Heuer. Дополнительные особенности: встроенная система управления голосовыми командами, Google Translate, Maps, уведомления, Google Fit, интуитивный интерфейс, управление музыкой с возможностью загружать музыку прямо на часы, загрузка приложений из Play Store. My Tag Heuer Connected App - специальное приложение для смартфонов, делающее возможным взаимодействие с часами TAG Heuer. Tag Heuer Studio - приложение для выбора персонального циферблата. Стальной безель. Съемные ушки корпуса. Ремешок со съемной раскладывающейся застежкой. Застежка с системой блокировки.</p>\r\n",
                price = 79000,
                old_price = 100000,
                status = 1,
                keywords = "Швейцарские умные наручные часы",
                description = "Швейцарские смарт-часы в проверенном качестве с модульной концепцией - уникальный образец современных технологий на вашем запястье.",
                img = "c627e17aa799ba45b7abb049deb3d2fb.jpg",
                hit = 0,
                cat = "Электронные"
            }
        };

        public bool CheckEqualsLists(ref JsonProduct[] products)
        {
            if(products.Length == allProducts.Length)
            {
                for(int i = 0; i < allProducts.Length; ++i)
                {
                    if (!allProducts[i].CheckEqualProducts(ref products[i]))
                        return false;
                }
                return true;
            }

            return false;
        }
    }
}