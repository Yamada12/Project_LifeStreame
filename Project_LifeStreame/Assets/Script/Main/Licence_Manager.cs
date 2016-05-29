using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

    /// <summary>
    /// ItemList制御クラス
    /// 現在未使用（スクロールビューを作るときに使う）
    /// </summary>
    public class Licence_Manager : MonoBehaviour
    {
        /// <summary>
        /// ItemList内コンテンツオブジェクト
        /// </summary>
        [SerializeField]
        private GameObject _itemListContent = null;

        /// <summary>
        /// ItemNoede
        /// </summary>
        [SerializeField]
        private GameObject _itemNode = null;

        /// <summary>
        /// ItemNode内オブジェクト
        /// </summary>
        private Image _itemImage = null;
        private Text _itemName = null;

        /// <summary>
        /// Contents内オブジェクト
        /// </summary>
        private Text _itemDetail = null;
        private Text _itemCnt = null;

        /// <summary>
        /// アイテムマスタStruct
        /// </summary>
        private struct ItemListMaster
        {
            public int itemId;     // ItemId
            public string name;    // 名前
            public string detail;  // 詳細
            public int headCap;    // 所持可能数
            public int buy;        // 買値
            public int sell;       // 売値
            public int category;   // カテゴリ
            public int skillType;  // スキルタイプ
            public int skillId;    // スキルID
        }

        /// <summary>
        /// ユーザー所持アイテムデータ
        /// </summary>
        private struct UserItemData
        {
            public int itemId; // アイテムId
            public int cnt;    // 所持数
            public bool isNew; // newフラグ
        }

        /// <summary>
        /// アイテムマスタリスト
        /// </summary>
        private List<ItemListMaster> _itemListMst = new List<ItemListMaster>();

        /// <summary>
        /// ユーザ所持アイテムデータリスト
        /// </summary>
        private List<UserItemData> _userItemDataLst = new List<UserItemData>();

        /// <summary>
        /// リストロードフラグ
        /// </summary>
        private bool _isLoad = false;

        /// <summary>
        /// デバッグデータロード処理
        /// TODO:後で削除
        /// </summary>
        private void DebugDataLoad()
        {
            // ItemMasterデータロード
            _itemListMst.Clear();
            for (int itemMstCnt = 0; itemMstCnt < 50; itemMstCnt++)
            {
                ItemListMaster itemMstData = new ItemListMaster();
                itemMstData.itemId = itemMstCnt;
                itemMstData.name = "テストアイテム" + itemMstCnt;
                itemMstData.detail = "テストを行うアイテム" + itemMstCnt;
                itemMstData.headCap = itemMstCnt * 10;
                itemMstData.buy = itemMstCnt * 11;
                itemMstData.sell = itemMstCnt * 12;
                itemMstData.category = itemMstCnt / 10;
                itemMstData.skillType = itemMstCnt / 5;
                itemMstData.skillId = itemMstCnt / 6;

                _itemListMst.Add(itemMstData);
            }

            // UserItemDataロード
            _userItemDataLst.Clear();
            for (int itemCnt = 0; itemCnt < 50; itemCnt++)
            {
                if (itemCnt % 3 != 0)
                {
                    UserItemData userItemData = new UserItemData();
                    userItemData.itemId = itemCnt;
                    userItemData.cnt = itemCnt * 5;
                    userItemData.isNew = (itemCnt % 2 == 0);

                    _userItemDataLst.Add(userItemData);
                }
            }
        }

        /// <summary>
        /// 初期化処理
        /// </summary>
        void Start()
        {
            // TODO:テストデータのロード
            DebugDataLoad();

            // ItemNode内の各オブジェクトの取得
            //_itemImage = _itemNode.transform.FindChild("ItemImg").GetComponent<Image>();
            _itemName = _itemNode.transform.FindChild("name").GetComponent<Text>();

            // ItemList内の各オブジェクト取得
            //_itemDetail = transform.FindChild("Contents/Detail").GetComponent<Text>();
            //_itemCnt = transform.FindChild("Contents/HaveCnt").GetComponent<Text>();

            CreateItemList();

        }

        /// <summary>
        /// アイテムリスト生成処理
        /// </summary>
        private void CreateItemList()
        {
            bool isFirst = true;

            if (!_isLoad)
            {
                // ユーザが所持しているアイテムの種類の数だけノードを生成
                foreach (UserItemData userData in _userItemDataLst)
                {
                    ItemListMaster itemData = _itemListMst.Find(local => local.itemId == userData.itemId);

                    if (itemData.itemId != null)
                    {
                        _itemName.text = itemData.name;

                        if (isFirst)
                        {
                            // 詳細部に１レコード目のデータの情報をセット
                            //_itemDetail.text = itemData.detail;
                            //_itemCnt.text = userData.cnt.ToString();
                            isFirst = false;
                        }

                        // 別クラスに定義している子オブジェクトをインスタンス化するための関数
                        Button node = SetChild(_itemListContent, _itemNode).GetComponent<Button>();

                        // SetChild関数の中身
                        /*
                            /// <summary>
                            /// 子オブジェクトセット処理
                            /// </summary>
                            /// <param name="parent"></param>
                            /// <param name="child"></param>
                            /// <param name="name"></param>
                            /// <returns></returns>
                            public Transform SetChild(GameObject parent,GameObject child,string name = null)
                            {
                                // プレハブからインスタンスを生成
                                GameObject obj = Instantiate(child);

                                // 作成したオブジェクトを子として登録
                                obj.transform.SetParent(parent.transform);

                                obj.transform.localPosition = new Vector3(0f, 0f, 0f);
                                obj.transform.localScale = new Vector3(1f, 1f, 1f);

                                // 作成したオブジェクトの名前にが(Clone)がつかないようにプレハブの名前を再付与
                                obj.name = (name != null) ? name : child.name;

                                return obj.transform;
                            }
                        */

                        // 参照渡しだとAddListner時に値がうまくセットされないため値渡しに変換
                        ItemListMaster data = itemData;
                        int cnt = userData.cnt;

                        // ノードクリック時に詳細が表示されるようにイベントを付与
                        node.onClick.AddListener(() => ItemSetting(data, cnt));
                    }
                }
                _isLoad = true;
            }
        }

        /// <summary>
        /// 詳細設定処理
        /// </summary>
        /// <param name="data"></param>
        /// <param name="cnt"></param>
        private void ItemSetting(ItemListMaster data, int cnt)
        {
            _itemDetail.text = data.detail;
            _itemCnt.text = cnt.ToString();
        }

    public Transform SetChild(GameObject parent, GameObject child, string name = null)
    {
        // プレハブからインスタンスを生成
        GameObject obj = Instantiate(child);

        // 作成したオブジェクトを子として登録
        obj.transform.SetParent(parent.transform);

        obj.transform.localPosition = new Vector3(0f, 0f, 0f);
        obj.transform.localScale = new Vector3(1f, 1f, 1f);

        // 作成したオブジェクトの名前にが(Clone)がつかないようにプレハブの名前を再付与
        obj.name = (name != null) ? name : child.name;

        return obj.transform;
    }
}