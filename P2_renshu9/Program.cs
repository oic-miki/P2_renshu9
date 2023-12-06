using Microsoft.EntityFrameworkCore.Update.Internal;
using P2_renshu9.Models;
using System.Runtime.InteropServices;

/*
 * INSETRT
 */
create();

void create()
{
    MemberContext memberContext = new MemberContext();
    Member member = new Member();
    member.MemberName = "自分の名前";
    member.MemberTel = "自分の電話番号";
    memberContext.Members.Add(member);
    memberContext.SaveChanges();
    memberContext.Dispose();
}

