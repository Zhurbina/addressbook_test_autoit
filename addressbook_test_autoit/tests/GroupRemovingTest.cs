﻿using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_test_autoit
{
    [TestFixture]
    public class GroupRemovingTests : TestBase
    {
        [Test]
        public void TestGroupRemoving()
        {
            int N = 1;
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            if (oldGroups.Count < 2)
            {
                GroupData newGroup = new GroupData()
                {
                    Name = "Test111"
                };

                app.Groups.Add(newGroup);
            }

            GroupData removedGroup = new GroupData();

            app.Groups.RemoveGroup(N, removedGroup);

            List<GroupData> newGroups = app.Groups.GetGroupList();



            oldGroups.Remove(removedGroup);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
