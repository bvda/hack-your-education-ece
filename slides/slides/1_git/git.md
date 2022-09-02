
<!-- .slide: data-background="#003d73" -->
## Git + Github

![AU Logo](./../img/HACK_LOGO.png "AU Logo") <!-- .element style="width: 200px; position: absolute; top: 200px; left: 50px" -->

----

## Agenda

* What is Git & Github
* How do I use Git & Github
* Lots of work

---

## Git and Github Desktop install

* Windows (https://git-scm.com/download/win)
* Mac (https://git-scm.com/download/mac)
* Linux (apt): sudo apt-get install git
* Linux (yum): sudo yum install git

* Github for Desktop

----

### What is Version control

* A system that keeps records of your change history
* Allows a group to develop together
* Creates a history of changes
* Gives the posibility to revert to an ealier state

----

### Why?

* We make mistakes
* We want to track the reason why something changed
* We want to work together easily

----

### What is Git

* Distributed version control
* Each user keep entire history and code on local machine
     * Changes can be made in offline mode
     * Require internet to share - ofcourse :)
* There are other VCS system out there
    * Subversion
    * CVS
    * etc.

----

### What is Github

* Place to host and share repositories
* Create an account on [www.github.com](http://www.github.com)
    * Free with limits
* On top of Git
    * UI, documentation, bug tracking, feature request, pull request
* Github is one platform:
    * Bitbucket, GitLab etc. are alternatives

---

### Create project on Github

![Create project on Github](./img/github-create.png "Create project on Github") <!-- .element: style="height: 600px" -->

----

### Ignore

![Git ignore templates](./img/gitignore.png "Templates on github")


----

### Ignore

* Just a file called '.gitignore'
* Which contains regexp of files to be ignored

```
.svn
log/*.log
tmp/**
node_modules/
.sass-cache
```

----

### Add collaborators

![Manage access](./img/access.png "Manage user access") <!-- .element: style="height: 600px" -->


----

### Invite users

![Invite users](./img/invites.png "Invite users") <!-- .element: style="height: 300px" -->

----

### Confirmation

Remember to answer confirmation email

![Mail](./img/confirmation.png "Confirmation email") <!-- .element: style="height: 600px" -->

----

### Create project localy

Or locally on console

```shell
$ git init
## later attach a remote repository
$ git add remote origin https://github.com/hkirk/FaceSite
```

---

### Commit 

* The act of creating a snapshot
    * and the actually snapshot
* A repository consists of a series of commits
* Each commit consists of
    * Information about how file has changed
    * Reference to previous commit (parent commit)
    * A hash code

----

### Repository

* A collection of the files
* and their history
* Will live locally and possible also on a remote server
    * Cloning is the act of copying the content
* Pulling from a repository
    * Copying remote changes to local
* Pushing to a repository
    * Moving local changes to remote

----

## Cloning repository

1. Goto www.github.com/hkirk/GitLecture
2. Fork this to optain you own copy
![Fork repository on github](./img/fork.png "Fork on github") <!-- .element: style="height: 150px" -->
3. 

```shell
$ git clone git@github.com:hkirk/GitLecture.git
```

----

### Cloning via Github Desktop

or

![Clone](./img/clone.png "Clone repository")

Note:
If you have cloned before forking

```
$ git remote -v
$ git remote remove origin
$ git remote add origin git@github.com:Henrik-Personal/GitLecture.git
$ git push --set-upstream origin main
```


----

### Basic Git commands 1

* **status**
    * shows which branch you are one (more about branches later)
    * shows working tree information
    * shows how your branch are compared to remove branch
* **log**
    * shows you snapshot history
    * *-n*, *--oneline*, *--graph*

----

### Basic git commands 2

* **add**
    * adds file to staging
* **commit**
    * commits files added to staging to repository
    * *-m* 

----

## Other usefull (non-git) commands

* **touch**
    * creates an empty file
* **echo**
    * prints
* **>>**
    * appends output from left side to file on right side
    * `echo "Hej" >> file.txt`
* **>**
    * overwrites file on right side

----

### Ex.: What is in the directory

1. What does **status** and **log** say in GitLecture?
2. Create a file 'plan.txt' and **add** to staging
3. Check *status*
4. **Stage** and **commit** and check **status**
5. Change content of 'plan.txt'
6. Check **status**, 
7. Then *stage* and **commit** 
7. How does the **log** look now?

---

## Branches

* A commit must 'live' on some branch
* There can be many parallel branches simultanius
* The main branch is typically called 'main', 'master' or 'development'

----

* <!-- .element: class="fragment" --> `HEAD` is the most recent commit on main branch
* <!-- .element: class="fragment" --> `master` is the branch

![Branches](./img/head.png "Branches")

----

### Branches

![Multiple branches](./img/branches.png "Branches") <!-- .element: style="height: 400px" -->

----

### Commands regarding branches

* **checkout [name]**
    * switches to given branch
* **checkout -b [name]**
    * Creates the branch and switches
* **branch**
    * Lists all branches
* **branch [name]**
    * Creates a new branch
* **diff [name]**
    * Show differences on current and `[name]` branched

----

<!-- .slide: style="font-size: 0.8em" -->

### Ex. Branching

1. Which branch are you on?
2. Create a new **branch** '[initials]-branch', and show branches
3. Switch to the new branch and watch what the **status** displays now
4. How do you workspace now look?
5. Create a new file 'file.txt' containing you name
6. **Stage** file and commit, check **log**
7. Switch back to the main branch
8. Create a file 'file2.txt' with some code
9. Add a commit file and check **log**
10. What are the difference on main and your new branch

---

### Merging

* Once a feature is done - you want to merge it back to you 'main' branch

```
      A---B---C topic
     /
D---E---F---G  master
```

`$ git merge topic` <!-- .element: class="fragment" -->

```
      A---B---C topic
     /         \
D---E---F---G---H main
```
<!-- .element: class="fragment" --> 

----

### Merging continued and cleanup

* **merge** and **diff**
    * can handle multiple branches at once
* **branch -d [name]**
    * Deletes the branch with `[name]`

----

<!-- .slide: style="font-size: 0.8em" -->

### Ex. Merging

1. Create a branch 'uppercase' and check this out.
2. Edit the file greeting.txt and make an uppercase greeting
3. Stage the file and commit. Check **log** with **--oneline --graph --all**
4. Checkout the 'main' branch
5. Check content of greeting.txt with `cat greeting.txt` or in an editor
6. What is the **diff**erence between 'uppercase' into 'main'
7. Then **merge** 'uppercase' into 'main'
8. What is the content of greeting.txt now?
9. Delete the uppercase branch

----

### Fixing conflicts

* Merging a branch can resolve in conflicts
    * This is merges that git cannot it self resolve.
* Example of conflict in a file
```
<<<<<<< HEAD
foreach (var i in range)
{
=======
for (int i = 0; i < 10; i++)
{
>>>>>>> conflicting-branch
```

----

### Resolving conflicts

* **status** will show unmerge paths
* Steps:
    1. Manually resolve each file
    2. **add** add each file to mark resolution
    * or **merge --abort** to abort merge

----

### Ex. working with conflicts

1. **merge** the branch 'conflicting-greetings' 
2. Use **status** to show changes
3. Use an editor to fix the conflicts
4. **status** also show instructions for how to resolve conflicts
5. What do **log --oneline --graph** show now?

---

## Amend

* Some times we commit and miss something important
     * amend can help us fix this

* **amend**
    * Replaces lastest commit on current branch

----

### Ex. using amend

1. Create a file 'bar.txt', **stage** and **commit**
2. What do **status** look like?
3. What do **log -p** show?
4. Note which name appears the most on the enrollment list
5. Add name to 'bar.txt' and stage it
6. Amend these changes by **commit --amend**
7. Check **log p**
8. Try amending againg, what happens?

---

<!-- .slide: style="font-size: 0.9em" -->

## Sharing on Github

* **push**
    * Pushes current branch to remote
* **push --set-upstream <remote> <branch>**
    * Tells which remote a branch should be pushed to as default
    * Only nessesary for new branches
* **pull**
    * Incorporates changes from remote into current branch
    * shorthand for `git fetch; git merge FETCH_HEAD`

----

### Pull requests

* Forking a repository on GitHub creates a new repository with the same code
    * and a link between these
* A pull requests is the tool to synchronize the to repositories

**Note** if you share access to a private repository pull request is no nessesary - because there are only one repository.

----

### Creating a pull request 1

![New pull request](./img/create-pull-request.png "New pull request")

----

### Creating a pull request 1

![Validate pull request](./img/create-pull-request2.png "Validate pull request")

----

### Updates from main repository

![Update from repo](./img/update-downstream.png "Update from main repositor")

----

### Ex. Working with github

1. **push** your changes on the branches 'main' and '[initials]-branch' to your github account
2. Create a pull request to 'hkirk/GitLecture'

---

## References:

* [A Visual Git Reference](http://marklodato.github.io/visual-git-guide/index-en.html)

