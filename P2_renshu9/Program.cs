/*
 * SELECT
 */
using P2_renshu9.Models;

select();

void select()
{
    MemberContext memberContext = new MemberContext();
    foreach (Member member in memberContext.Members)
    {
        Console.WriteLine($"{member.MemberName}さんの電話番号は{member.MemberTel}です。");
    }
    memberContext.Dispose();
}
