/*
 * UPDATE
 */
using P2_renshu9.Models;

update();

void update()
{
    MemberContext memberContext = new MemberContext();
    Member member = memberContext.Members.First();
    member.MemberTel = "秘密";
    memberContext.SaveChanges();
    memberContext.Dispose();
}
