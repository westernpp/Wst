#include<stdio.h>
#include<stdlib.h>
#include<string.h>
// #include"myFunction.h"
void loginPage();
void loginPrompt();
// void InsertByValue_LinkList(struct LinkNode *header);
int choice = -1;//����һ��ȫ�ֱ������ñ�����ŵ����û�ѡ������

//����û�ע����˺�����
typedef struct LoginData
{
    char userName[20];
    char keyBoard[20];
};
//����һ���ڵ��������� -->�û�ע����˺�����Ľڵ�
typedef struct LoginDataNode
{
    struct LoginData userData;
    struct LoginDataNode *next;
}node_1;

//ѧ���ɼ�
struct score{
    int math;
    int english;
    int java;
    int python;
    int physics;
};
//ѧ����Ϣ
struct  students
{
    char name[20];
    char num[5];//ѧ��
    char gender[5];//�Ա�
    int sum;//�ܷ�
    int aver;
    struct score score;    
};
//����һ���ڵ���������
struct LinkNode{
    //������
    struct students;
    //ָ����
    struct LinkNode *next;
};
struct LinkNode* header;
void loginPrompt()
{
    printf("  _______________________________________________________________________________________________________________  \n");
    printf("\n");
    printf("  *************************************************************************************************************** \n");
    printf("\n\n\n\n\n\n\n");
    printf("                                 O(��_��)O~��ӭʹ��ѧ����Ϣ����ϵͳ~ O(��_��)O\n\n");
    printf("                                          ��ѡ���Ӧ����ݵ�½ϵͳ\n");
    printf("                                       _____________________________\n\n");
    printf("                                          --->>> 1.������ʦ <<<---\n");
    printf("                                          --->>> 2.����ѧ�� <<<---\n");
    // printf("                                          --->>> 3.�û�ע�� <<<---\n");
    printf("\n\n\n\n\n\n\n");
    printf("  *************************************************************************************************************** \n");
    printf("\n");
    printf("  _______________________________________________________________________________________________________________  \n");
    loginPage();

}

//�û���¼
void loginPage()
{
    
    node_1 *newLogin();
    // int choice;
    // char workNum[20] = "03062201"; //��ʦ����
    // char workKey[20] = "teacher123"; //��ʦ
    char Inset_workNum[20]; //����û�����Ľ�ʦ����
    char Inset_workKey[20];
    char Inset_stuNum[20];
    char Inset_stuKey[20];
    while (1)
    {
        scanf("%d",&choice);
        if(choice == 1)//�û�ѡ������Ϊ��ʦ
        {
            system("cls");//�����ǰ��Ļ��������
            printf("                                 �����빤�ţ�");
            scanf("%s",&Inset_workNum);
            printf("                                 ���������룺");
            scanf("%s",&Inset_workKey);
            printf("                                 ��¼�ɹ���\n");
            return;
        }
        else if(choice == 2)
        {
            system("cls");//�����ǰ��Ļ��������
            printf("                                 ������ѧ��:");
            scanf("%s",&Inset_stuNum);
            printf("                                 ���������룺");
            scanf("%s",&Inset_stuKey);
            printf("                                 ��¼�ɹ���\n");
            return;
        }
        // else if(choice == 3) //ע��һ�����˺�
        // {
        //     newLogin();
        // }
        else
        {
            printf("������Ч������������");
            continue;
        }
    }
}

//�û�ע��-->��ʱû����
node_1 *newLogin()
{
    //��ʼ������
    //����һ��ͷ���ڵ�
    node_1 *header = (node_1 *)malloc(sizeof(node_1));
    header->next = NULL;

    //����һ��β���ڵ� Ĭ��ָ��ͷ���ڵ�
    node_1 *pRear;
	pRear = header;

    //�û�����
    char temp_userName[20];
    char temp_userKey[20];
    while (1)
    {
        printf("�����û�����");
        scanf("%s",&temp_userName);
        printf("�������룺");
        scanf("%s",&temp_userKey);
        break;
    }
    
    printf("%s,%s",temp_userKey,temp_userName);//û����

    //�����½ڵ����û����������
    node_1 *newNode = malloc(sizeof(node_1));
    // newNode->userData.userName = temp_userName;

    newNode->next = NULL;

    //��β��ָ��ָ���½ڵ�
    pRear->next = newNode;

    //����ָ��
    pRear = newNode;

    printf("%p,%p",newNode->userData.userName,newNode->userData.keyBoard);

    //�û���������
    // while (1)
    // {
    //     printf("�����û�����");
    //     scanf("%s",newNode->userData.userName);
    //     printf("�������룺");
    //     scanf("%s",newNode->userData.keyBoard);
    //     char temp[20] = newNode->userData.keyBoard;//��ʱ����û����������
    //     printf("ȷ�����룺");
    //     scanf("%s",newNode->userData.keyBoard);
    //     if(temp == newNode->userData.keyBoard)
    //     {    
    //         printf("ע��ɹ�");
    //         break;
    //     }
    //     else
    //     {
    //         printf("������������벻һ�£�");
    //     }

    //     //
    // }
    
}


//¼��ѧ����Ϣ
//��ʼ������
struct LinkNode *Init_LinkList()
{

    if(choice == 2)
    {
        printf("  _______________________________________________________________________________________________________________  \n");
        printf("\n");
        printf("  *************************************************************************************************************** \n");
        printf("\n\n\n\n\n\n\n\n\n");
        printf("                                             ��û�и�Ȩ�ޣ�\n");
        printf("\n\n\n\n\n\n\n\n\n");
        printf("  *************************************************************************************************************** \n");
        printf("\n");
        printf("  _______________________________________________________________________________________________________________  \n");
        return;
    }

        int n;//�ж��Ƿ����¼��ѧ����Ϣ

        //����һ��ͷ���ڵ�
        struct LinkNode *header = malloc(sizeof(struct LinkNode));//Ϊͷ���ڵ����һ��ռ�
        header->next = NULL;

        //β��ָ��
        struct LinkNode *pRear = header; //β��ָ��Ĭ��ָ��ͷ���ڵ�

        //�û���������
        while (1)
        {
            system("cls");
            //����һ���½ڵ�
            struct LinkNode *newNode = malloc(sizeof(struct LinkNode));
            newNode->next = NULL;

            printf("  _______________________________________________________________________________________________________________  \n");
            printf("\n");
            printf("  *************************************************************************************************************** \n");
            printf("\n\n\n\n");
            printf("                                                  ����ѧ��������");
            scanf("%s",newNode->name);
            printf("                                                  ����ѧ��ѧ�ţ�");
            scanf("%s",newNode->num);
            printf("                                                  ����ѧ���Ա�");
            scanf("%s",newNode->gender);
            printf("                                                  �����ѧ���ĸ����ɼ���");
            scanf("%d",&newNode->score.math);//int���� ����ʱҪ��ȡ��ַ��     
            printf("                                                  �����ѧ���Ĵ�ѧӢ��ɼ���");
            scanf("%d",&newNode->score.english);
            printf("                                                  �����ѧ���Ĵ�ѧ����ɼ���");
            scanf("%d",&newNode->score.physics);
            printf("                                                  �����ѧ����python�ɼ���");
            scanf("%d",&newNode->score.python);
            printf("                                                  �����ѧ����Java�ɼ���");
            scanf("%d",&newNode->score.java);
            printf("                                                  ¼�����,�Ƿ����¼�룿(1.yes/2.no)\n");
            scanf("%d",&n);
            printf("\n\n\n\n");
            printf("  *************************************************************************************************************** \n");
            printf("\n");
            printf("  _______________________________________________________________________________________________________________  \n");

            //��β��ָ��ָ���½ڵ�
            pRear->next = newNode;//

            //���½ڵ�
            pRear = newNode;

            // printf("%d\n",newNode->data);
            
            if(n==1)
            {    
                // system("cls");
                continue;
            }
            else
            {
                // //����¼�� ���ز˵�
                // menu();
                break;
            }
        }
        return header;
}

//����ѧ����Ϣ
void InsertByValue_LinkList()
{
    if(header==NULL)
    {
        printf("����ѧ����Ϣ��");
        return;
    }
    if(choice == 2)
    {
        printf("  _______________________________________________________________________________________________________________  \n");
        printf("\n");
        printf("  *************************************************************************************************************** \n");
        printf("\n\n\n\n\n\n\n\n\n");
        printf("                                             ��û�и�Ȩ�ޣ�\n");
        printf("\n\n\n\n\n\n\n\n\n");
        printf("  *************************************************************************************************************** \n");
        printf("\n");
        printf("  _______________________________________________________________________________________________________________  \n");
        return;
    }
    //������������ָ��
    struct LinkNode *prev = header; //һ��ָ��ͷ��
    struct LinkNode *pCurrent = prev->next; //��һ��ָ����һ���ڵ㣨��Ϊͷ����next��ŵľ�����һ���ڵ�ĵ�ַ��

    //
    printf("  _______________________________________________________________________________________________________________  \n");
    printf("\n");
    printf("  *************************************************************************************************************** \n");
    printf("\n\n\n");
        while (1)
        {
             //�ҵ�������
            printf("Ҫ��ѧ��Ϊ����ѧ��ǰ��������ݣ�");
            char oldVal[5];
            scanf("%s",&oldVal);
            while (pCurrent != NULL)
            {
                if( strcmp(pCurrent->num,oldVal)==0 )
                     break;//�ҵ��˾��˳�ѭ��
                //û�ҵ���������ָ�����������
                prev =pCurrent;
                pCurrent = pCurrent->next;
            }
            //���һֱû�ҵ������ݣ���ô���pCurrent��ֵ��ָ���
            if(pCurrent==NULL)
            {
                printf("û���ҵ�ѧ��Ϊ%s��ѧ����\n",oldVal);
                printf("1.��������\n");
                printf("2.���ز˵�\n");
                int x;
                scanf("%d",&x);
                if(x==1)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }   
            else
            {
                //�ҵ������ݺ� ��ʾ�û�����������
                printf("������Ҫ�����ѧ����Ϣ��\n");
                //����һ���½ڵ�
                struct LinkNode *newNode = malloc(sizeof(struct LinkNode));
                newNode->next = NULL;
                printf("                                                  ����ѧ��������");
                scanf("%s",newNode->name);
                printf("                                                  ����ѧ��ѧ�ţ�");
                scanf("%s",newNode->num);
                printf("                                                  ����ѧ���Ա�");
                scanf("%s",newNode->gender);
                printf("                                                  �����ѧ���ĸ����ɼ���");
                scanf("%d",&newNode->score.math);//int���� ����ʱҪ��ȡ��ַ��     
                printf("                                                  �����ѧ���Ĵ�ѧӢ��ɼ���");
                scanf("%d",&newNode->score.english);
                printf("                                                  �����ѧ���Ĵ�ѧ����ɼ���");
                scanf("%d",&newNode->score.physics);
                printf("                                                  �����ѧ����python�ɼ���");
                scanf("%d",&newNode->score.python);
                printf("                                                  �����ѧ����Java�ɼ���");
                scanf("%d",&newNode->score.java);
                printf("                                                  ¼�����,�Ƿ����¼�룿(1.yes/2.no)\n");
                int n;
                scanf("%d",&n);
                //���½ڵ��������
                newNode->next = pCurrent;
                prev->next = newNode;
                //�ж��Ƿ����¼����Ϣ
                if(n==1)
                    continue;
                else
                    break;
            }        
    }
    printf("\n\n\n");
    printf("  *************************************************************************************************************** \n");
    printf("\n");
    printf("  _______________________________________________________________________________________________________________  \n");
}

//�鿴����ѧ����Ϣ ->��������
void Foranch_LinkList()
{
    if(header == NULL)
    {
        printf("����ѧ����Ϣ��");
        return;
    }
    // ����һ����ֵָ��
    struct LinkNode *pCurrent = header->next;//��Ϊͷ���ڵ㲻�洢��Ч���ݣ�����Ҳ�Ͳ���ӡ��ֱ���ø�ֵָ��ָ��ͷ���ڵ��next����
    
    printf("  _______________________________________________________________________________________________________________  \n");
    printf("\n");
    printf("  *************************************************************************************************************** \n");
    printf("\n\n");
    printf("                                             ѧ���ɼ�\n");
    printf("\t ѧ��\t����\t�Ա�\t����\t��ѧӢ��    ��ѧ����    python    Java    �ܷ�    ƽ����\t\n");
    while (pCurrent!=NULL)
    {
        //�����ܷ�
        int sum=0;
        sum+=pCurrent->score.english;
        sum+=pCurrent->score.java;
        sum+=pCurrent->score.math;
        sum+=pCurrent->score.physics;
        sum+=pCurrent->score.python;
        //����ƽ����
        int aver = sum/5;

        printf("\t  %s \t",pCurrent->num);
        printf("%-8s ",pCurrent->name);//��ÿһ������� ���ÿ��
        printf("%-6s  ",pCurrent->gender);
        printf("%-6d   ",pCurrent->score.math);
        printf("%-6d      ",pCurrent->score.english);
        printf("%-6d      ",pCurrent->score.physics);
        printf("%-6d   ",pCurrent->score.python);
        printf("%-6d  ",pCurrent->score.java);
        printf("%-6d  ",sum);
        printf("%-6d",aver);
        printf("\n");
        pCurrent = pCurrent->next;
    }
    printf("\n\n\n\n");
    printf("  *************************************************************************************************************** \n");
    printf("\n");
    printf("  _______________________________________________________________________________________________________________  \n");
 }

//��ѯ����ѧ����Ϣ
void ForOne_LinkList()
{

    if(header == NULL)
    {
        printf("����ѧ����Ϣ��");
        return;
    }
    // ����һ��ָ��
    struct LinkNode *pCurrent = header->next;
    char num[5];
    printf("����Ҫ���ҵ�ѧ��ѧ�ţ�");
    scanf("%s",&num);
    //����
    while (pCurrent!=NULL)
    {
        // printf("����%s\n",num);
        // printf("��ǰ%s",pCurrent->num);
        if(strcmp(pCurrent->num,num)==0)
        {
            //�����ܷ�
            int sum=0;
            sum+=pCurrent->score.english;
            sum+=pCurrent->score.java;
            sum+=pCurrent->score.math;
            sum+=pCurrent->score.physics;
            sum+=pCurrent->score.python;
            //����ƽ����
            int aver = sum/5;

            printf("  _______________________________________________________________________________________________________________  \n");
            printf("\n");
            printf("  *************************************************************************************************************** \n");
            printf("\n\n");
            printf("                                             ѧ���ɼ�\n");
            printf("\t ѧ��\t����\t�Ա�\t����\t��ѧӢ��    ��ѧ����    python    Java    �ܷ�    ƽ����\t\n");
            printf("\t  %s \t",pCurrent->num);
            printf("%-8s ",pCurrent->name);//��ÿһ������� ���ÿ��
            printf("%-6s  ",pCurrent->gender);
            printf("%-6d   ",pCurrent->score.math);
            printf("%-6d      ",pCurrent->score.english);
            printf("%-6d      ",pCurrent->score.physics);
            printf("%-6d   ",pCurrent->score.python);
            printf("%-6d  ",pCurrent->score.java);
            printf("%-6d  ",sum);
            printf("%-6d",aver);
            printf("\n");
            break;
        }
        //û���ҵ� ����ָ��ָ����һ���ڵ�
        pCurrent = pCurrent->next;
    }
    //���û���ҵ� ���pcurrent��Ϊ��
    if(pCurrent == NULL)
    {
        printf("û���ҵ�ѧ��Ϊ%s��ѧ��!\n",num);
        printf("1.��������\n");
        printf("2.���ز˵�");
        int x;
        scanf("%d",&x);
        if(x=2)
            menu();
    }

}

//ɾ��ĳ��ѧ����Ϣ  //ɾ������
void RemoveByValue_LinkList()
{
    if(header == NULL)
    {
        printf("����ѧ����Ϣ��");
        return;
    }   
    if(choice == 2)
    {
        printf("  _______________________________________________________________________________________________________________  \n");
        printf("\n");
        printf("  *************************************************************************************************************** \n");
        printf("\n\n\n\n\n\n\n\n\n");
        printf("                                             ��û�и�Ȩ�ޣ�\n");
        printf("\n\n\n\n\n\n\n\n\n");
        printf("  *************************************************************************************************************** \n");
        printf("\n");
        printf("  _______________________________________________________________________________________________________________  \n");
        return;
    }
    //��ʾ�û�
    char n[5];
    printf("������Ҫɾ����ѧ����ѧ�ţ�");
    scanf("%s",&n);
    //������������ָ��
    struct LinkNode * prev = header;
    struct LinkNode * pCurrent = header->next;
    //����Ѱ��Ҫɾ��������
    while (pCurrent != NULL)
    {
        if(strcmp(pCurrent->num,n)==0) //�ҵ���Ҫɾ�������ݾ��˳�����
         {
            break;
         }
        //û���ҵ���������������ָ�������ƶ�
        prev = pCurrent;
        pCurrent = pCurrent->next;
    }
    //�������������û�ҵ�Ҫɾ�������ݣ���ôpCurrent��ֵ����Ϊ��
    if(pCurrent == NULL)
    {
        printf("û���ҵ���ѧ����\n");
        return 0;
    }
    else
    {
        //�ô�ɾ���ڵ��ǰ���ڵ�ָ���ɾ���ڵ�ĺ����ڵ� 
        // ������ɾ���ڵ���������û�б�ָ��Ҳ�͵��ڱ������ˣ������޷����ҵ������ɾ���ڵ�
        prev->next = pCurrent->next;
        //�ͷŴ�ɾ���ڵ���ڴ�
        free(pCurrent);
         pCurrent = NULL;
         printf("ɾ���ɹ���\n");
    }
        
}

//�������ѧ����Ϣ   //�������
void Clear_LinkList()
{
    if(header == NULL)
    {
        printf("����ѧ����Ϣ��");
        return;
    }
    if(choice == 2)
    {
        printf("  _______________________________________________________________________________________________________________  \n");
        printf("\n");
        printf("  *************************************************************************************************************** \n");
        printf("\n\n\n\n\n\n\n\n\n");
        printf("                                             ��û�и�Ȩ�ޣ�\n");
        printf("\n\n\n\n\n\n\n\n\n");
        printf("  *************************************************************************************************************** \n");
        printf("\n");
        printf("  _______________________________________________________________________________________________________________  \n");
        return;
    }
    //����һ������ָ��
    struct LinkNode *pCurrent;
    pCurrent = header->next;
    while (pCurrent!=NULL)
    {
        //�ȴ���һ���½ڵ㣬�����ݴ���һ���ڵ�
        struct LinkNode *pNext = pCurrent->next;
        //�ͷ�pCurrent��ǰ����
        free(pCurrent);
        //��pCurrentָ����һ���ڵ㣬Ҳ�������Ǹո��ݴ�Ľڵ�
        pCurrent = pNext;
    }
    header->next = NULL;
    printf("��ճɹ���\n");
}

//����ѧ����Ϣ
void save()
{
    if(header==NULL)
    {
        printf("����ѧ����Ϣ��\n");
        return;
    }
    FILE* f;
    f=fopen("studentsystem.xls","w");
    if(f==NULL)
    {
        printf("����ʧ��!\n");
        return;
    }
    //����һ������ָ��
    struct LinkNode *pCurrent = header->next;
    //
    if(header == NULL)
        printf("����ѧ����Ϣ��\n");
    else
    {
        while (pCurrent!=NULL)
        {
            //�����ܷ�
            int sum=0;
            sum+=pCurrent->score.english;
            sum+=pCurrent->score.java;
            sum+=pCurrent->score.math;
            sum+=pCurrent->score.physics;
            sum+=pCurrent->score.python;
            //����ƽ����
            int aver = sum/5;
            // fprintf(f,"����:%s\n",t->student.name);
            fprintf(f,"ѧ��\t����\t�Ա�\t����\t��ѧӢ��t\t��ѧ����\tpython\tJava\t�ܷ�\tƽ����\t\n");
            fprintf(f,"%s\t ",pCurrent->num);
            fprintf(f,"%s\t",pCurrent->name);
            fprintf(f,"%s\t",pCurrent->gender);
            fprintf(f,"%d\t",pCurrent->score.math);
            fprintf(f,"%d\t",pCurrent->score.english);
            fprintf(f,"%d\t",pCurrent->score.physics);
            fprintf(f,"%d\t",pCurrent->score.python);
            fprintf(f,"%d\t",pCurrent->score.java);
            fprintf(f,"%d\t",sum);
            fprintf(f,"%d\t",aver);
            fprintf(f,"\n");

            pCurrent = pCurrent->next;
        }
        printf("����ɹ�����");
    }
    
    
    fclose(f);
}

//�˳�ϵͳ->�ص���¼ѡ�����
void back()
{
    loginPrompt();
}

//�˵�
int menu()
{
    system("cls");
    printf("  _______________________________________________________________________________________________________________  \n");
    printf("\n");
    printf("  *************************************************************************************************************** \n");
    printf("                                                                                      ��¼�ɹ����������Ϊ��");
    if(choice == 1)
        printf("��ʦ\n\n");
    else
        printf("ѧ��\n\n");
    printf("\n\n\n\n");
    printf("                                 O(��_��)O~��ӭʹ��ѧ����Ϣ����ϵͳ~ O(��_��)O\n\n");
    printf("                                          >>>��ѡ��Ҫ���еĲ�����<<<\n");
    printf("                                           _______________________\n\n");
    printf("                                           1.¼��ѧ����Ϣ\n");
    printf("                                           2.����ѧ����Ϣ\n");
    printf("                                           3.ɾ������ѧ����Ϣ\n");
    printf("                                           4.��ѯ����ѧ����Ϣ\n");
    printf("                                           5.��ѯ����ѧ����Ϣ\n");
    printf("                                           6.�������ѧ����Ϣ\n");
    printf("                                           7.����ѧ����Ϣ\n");
    printf("                                           8.�˳���¼\n");
    printf("                                           9.�˳�ϵͳ\n");
    printf("\n\n\n\n");
    printf("  *************************************************************************************************************** \n");
    printf("  _______________________________________________________________________________________________________________  \n");
    //����û������ѡ��
    int n;
    scanf("%d",&n);
   return n;
}
int main()
{
    loginPrompt();
    int n;
    
     while (1)
    {
        n = menu();
        switch (n)
        {
            case 1:
                system("cls");
                header = Init_LinkList();
                system("pause");//������ͣ �����������
                system("cls");
                break; 
            case 2:
                system("cls");
                InsertByValue_LinkList();
                system("pause");
                system("cls");
                break;
            case 3:
                system("cls");
                RemoveByValue_LinkList();
                system("pause");
                system("cls");
                break;
            case 4:
            system("cls");
                ForOne_LinkList();
                system("pause");
                system("cls");
                break;
            case 5:
                system("cls");
                Foranch_LinkList();
                system("pause");
                system("cls");
                break;
            case 6:
                system("cls");
                Clear_LinkList();
                system("pause");
                system("cls");
                break;
            case 7:
                system("cls");
                save();
                system("pause");
                system("cls");
                break;
            case 8:
                system("cls");
                back();
                system("pause");
                system("cls");   
                break;
            case 9:
                system("cls");
                printf("\n\n\nn\n\n\n");
                printf("  _______________________________________________________________________________________________________________  \n");
                printf("\n");
                printf("  *************************************************************************************************************** \n");
                printf("\n\n\n\n");
                printf("                                          O(��_��)O~��лʹ�ã� O(��_��)O~\n");
                printf("\n\n\n\n");
                printf("  *************************************************************************************************************** \n");
                printf("  _______________________________________________________________________________________________________________  \n");
                return;     
        }

    }
}    