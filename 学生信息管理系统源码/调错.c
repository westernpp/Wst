#include<stdio.h>
#include<stdlib.h>
#include<string.h>
#include"myFunction.h"
void loginPage();
void loginPrompt();
// void InsertByValue_LinkList(struct LinkNode *header);
int choice = -1;//����һ��ȫ�ֱ������ñ�����ŵ����û�ѡ������

//����û�ע�����Ϣ
struct LoginData
{
    char userName[20];
    char keyBoard[20];
    int who;//���
};
//����һ���ڵ��������� -->�û�ע����˺�����Ľڵ�
typedef struct LoginDataNode
{
    struct LoginData userData;
    struct LoginDataNode *next;
}node_1;

//�û�ע��
//ʱ�䣺2023/2/17 16��52
//��������������ɹ� ������ʱ����3 ���øú��� û��Ч��
//ԭ�򣺵��ú�����ʱ���������Ҳд���ˡ���
//ʱ�䣺2023/2/20 �û���ע�Ṧ�ܲ�ȫ �޷����û���ע����Ϣ������������
node_1 *newLogin()
{
    //��ʼ������
    //����һ��ͷ���ڵ�
    node_1* loginHeader = malloc(sizeof(node_1));
    loginHeader->next = NULL;
    //����һ��β���ڵ�
    node_1* pRear = loginHeader;
    //��ʾ�û�����
    while (1)
    {
        //����һ���½ڵ�������
        node_1* newLoginNode = malloc(sizeof(node_1));
        newLoginNode->next==NULL;
        printf("���ǣ�(1.��ʦ/2.ѧ��)\n");
        scanf("%d",&newLoginNode->userData.who);
        printf("�����û�����");
        scanf("%s",newLoginNode->userData.userName);
        printf("��������:");
        char tempKey[20];//��ʱ����û����������
        gets(tempKey);
        printf("ȷ�����룺");
        scanf("%s",newLoginNode->userData.keyBoard);
        printf("temp=%s\n",tempKey);
        printf("->=%s",newLoginNode->userData.keyBoard);
        //�ж���������������Ƿ�һ��
        if(strcmp(tempKey,newLoginNode->userData.keyBoard)==0)
        {
            printf("ע��ɹ���\n");
            //��β��ָ��ָ���½ڵ�
            pRear->next = newLoginNode;
            //����ָ��
            pRear = newLoginNode;
            loginPrompt();
            break;
        }
        else
        {
            printf("������������벻һ�£�\n");
            continue;
        }
    }
    //���û�ע��������ݷ��ظ����ú���
    return loginHeader;
}
//��¼ѡ�����
void loginPrompt()
{
    system("cls");
    printf("  _______________________________________________________________________________________________________________  \n");
    printf("\n");
    printf("  *************************************************************************************************************** \n");
    printf("\n\n\n\n\n\n\n");
    printf("                                 O(��_��)O~��ӭʹ��ѧ����Ϣ����ϵͳ~ O(��_��)O\n\n");
    printf("                                          ��ѡ���Ӧ����ݵ�½ϵͳ\n");
    printf("                                       _____________________________\n\n");
    printf("                                          --->>> 1.������ʦ <<<---\n");
    printf("                                          --->>> 2.����ѧ�� <<<---\n");
    printf("                                          --->>> 3.�û�ע�� <<<---\n");
    printf("\n\n\n\n\n\n\n");
    printf("  *************************************************************************************************************** \n");
    printf("  _______________________________________________________________________________________________________________  \n");
    loginPage();
    //
    // node_1* loginHeader = malloc(sizeof(node_1));
    // loginHeader->next=NULL;
    // loginPage(loginHeader);

}
//��¼����
void loginPage()
{

    /*
        ����һ���µĽڵ����û�ע����˺����룬
        ����û�Ҫѡ����ʦ/ѧ������ĳһ��ݵ�¼ϵͳ,��Ҫ�������в�ѯ�û��Ƿ���ע������˺�
    */
    node_1* dataHeader = malloc(sizeof(node_1));
    dataHeader = NULL;
   //
   char uname[20];
   char key[20];
   while (1)
   {
        scanf("%d",&choice);
        if(choice == 1)//��ʦ��¼
        {
            printf("�����빤�ţ�");
            scanf("%s",&uname);
            printf("���������룺");
            scanf("%s",&key);
            //�û������˺��������Ҫ�������������������Ƿ��д������˺�����
            if(dataHeader == NULL)
            {
                printf("�����ڸ��û���\n");
            }
            else
            {
                //dataHeader�������ݣ����������
                while (dataHeader!=NULL)
                {
                    //�ж��û����뼰����Ƿ��Ӧ
                    if(strcmp(uname,dataHeader->userData.userName)==0 && strcmp(key,dataHeader->userData.keyBoard) && choice==dataHeader->userData.who)
                    {
                        printf("��¼�ɹ���\n");
                        break;
                    }
                    else
                    {
                        printf("�û������������\n");
                        // loginPrompt();
                        break;
                    }
                    dataHeader = dataHeader->next;
                }
                
            }
        }  
        else if(choice == 2)//ѧ����¼
        {
            printf("������ѧ�ţ�");
            scanf("%s",&uname);
            printf("���������룺");
            scanf("%s",&key);
            //�û������˺��������Ҫ�������������������Ƿ��д������˺�����
            if(dataHeader == NULL)
            {
                printf("�����ڸ��û���\n");
            }
            else
            {
                //dataHeader�������ݣ����������
                while (1)
                {
                    //�ж��û����뼰����Ƿ��Ӧ
                    if(strcmp(uname,dataHeader->userData.userName)==0 && strcmp(key,dataHeader->userData.keyBoard) && choice==dataHeader->userData.who)
                    {
                        printf("��¼�ɹ���\n");
                        break;
                    }
                    else
                    {
                        printf("�û������������\n");
                        loginPrompt();
                        break;
                    }
                }               
            }
        }
        else //ע�����˺�
        {
            //����ע���˺ŵĺ���
            dataHeader = newLogin();           
        }
   }
   
   
}



int main()
{
    loginPrompt();
    loginPage();
}