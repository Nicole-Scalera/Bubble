<a id="article-top"></a>

<!-- TITLE -->
<br />
<div align="center">

<h1 align="center">Mista Bubble</h1>
<h3 align="center">▸ Guide to Getting Started ◂</h3>

  <p align="center">
    A guide for anyone contributing to the<br />
    <i>Mista Bubble</i> repository.
    <br />
  </p>
</div>

<!-- TABLE OF CONTENTS -->
<div style="font-size:16px;">
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#overview">Overview</a></li>
      <ol type="i">
        <li><a href="#there-is-a-lot-of-text-here-where-do-i-start">There is a LOT of Text Here... Where Do I Start?</a></li>
      </ol>
    <li><a href="#navigation">Navigation</a></li>
      <ol type="i">
        <li><a href="#unfamiliar-with-github">Unfamiliar With GitHub</a></li>
        <li><a href="#familiar-with-github">Familiar With GitHub</a></li>
      </ol>
    <li><a href="#repositories">Repositories</a></li>
      <ol>
        <li><a href="#what-is-a-repository">What Is a Repository?</a></li>
        <li><a href="#how-will-the-repository-be-used">How Will the Repository Be Used?</a></li>
      </ol>
    <li><a href="#committing">Committing</a></li>
      <ol type="i">
        <li><a href="#what-is-committing">What Is Committing?</a></li>
        <li><a href="#how-do-i-commit">How Do I Commit?</a></li>
      </ol>
    <li><a href="#remote-vs-local">Remote vs. Local</a></li>
      <ol type="i">
        <li><a href="#what-does-remote-mean">What Does Remote Mean?</a></li>
        <li><a href="#what-does-local-mean">What Does Local Mean?</a></li>
      </ol>
    <li><a href="#uploading-things-and-making-changes">Uploading Things & Making Changes</a></li>
      <ol type="i">
        <li><a href="#i-want-to-upload-files-through-my-browser-remote">I Want to Upload Files Through My Browser (Remote)</a></li>
        <li><a href="#i-want-to-upload-files-from-my-computer-local">I Want to Upload Files From My Computer (Local)</a></li>
        <li><a href="#fetch-origin">Fetch Origin</a></li>
        <li><a href="#push-origin">Push Origin</a></li>
      </ol>
    <li><a href="#committing-guidelines">Committing Guidelines</a></li>
      <ol type="i">
        <li><a href="#title-and-description">Title and Description</a></li>
        <li><a href="#commit-example">Commit Example</a></li>
      </ol>
    <li><a href="#branching-and-forking">Branching & Forking</a></li>
      <ol type="i">
        <li><a href="#to-branch-or-not-to-branch">To Branch, or Not to Branch...</a></li>
        <li><a href="#why-have-two-different-branches">Why Have Two Different Branches?</a></li>
        <li><a href="#when-should-i-merge-dev-into-main">When Should I Merge Dev Into Main?</a></li>
        <li><a href="#other-branches">Other Branches</a></li>
        <li><a href="#what-the-fork">What the Fork?!</a></li>
      </ol>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>
</div>

<br></br> <!-- Spacer -->


<!-- OVERVIEW -->
<div id="overview" style="font-size:16px;"> <!-- Link to Section -->
<h2>Overview</h2>

<p style="font-size:16px; margin-bottom: 30px;">Hello everyone! For easy reading, I've broken up this guide into bite-sized sections.</p>

<div id="there-is-a-lot-of-text-here-where-do-i-start" style="font-size:16px;">
<h3>There is a LOT of Text Here... Where Do I Start?</h3>
You may be asking yourself, *where should I even start?* Fear not! I've put together a table below that will help you <a href="#navigation">navigate</a> this guide.
</div>
</div>

<p align="right">(<a href="#article-top">back to top</a>)</p>

<br></br> <!-- Spacer -->


<!-- NAVIGATION -->
<div id="navigation" style="font-size:16px;"> <!-- Link to Section -->

<h2>Navigation</h2>

Take a look at the following questions to navigate this README. Each choice will tailor your reading experience.

<ol>
  <li>
    <strong>Are you familiar with GitHub?</strong>
    <br>
    <a href="#unfamiliar-with-github" style="margin-left:12px;">No, I need an introduction</a> |
    <a href="#familiar-with-github">Yes, I am very/pretty familiar</a>
  </li>
</ol>

</div>

<p align="right">(<a href="#article-top">back to top</a>)</p>

<br></br> <!-- Spacer -->


<!-- UNFAMILIAR WITH GITHUB -->
<div id="unfamiliar-with-github" style="font-size:16px;"> <!-- Link to Section -->
  <h2>Unfamiliar With Github</h2>
  <p>No problem! I am happy to help out. Here are the sections I would recommend you read:</p>
  <ol>
    <li><a href="#repositories">Repositories</a></li>
    <ul>
      <li>This section covers the basics of this repository and how to interact with it.</li>
    </ul>
    <li><a href="#committing">Committing</a></li>
    <li><a href="#remote-vs-local">Remote vs. Local</a></li>
    <li><a href="#uploading-things--making-changes">Uploading Things & Making Changes</a></li>
    <ul>
      <li>You will most likely be uploading <a href="#i-want-to-upload-files-through-my-browser-remote">remotely</a>, especially if you are a Writer, Artist, or Designer.</li>
      <li>However, you can also upload things <a href="#i-want-to-upload-files-from-my-computer-local">locally</a>, but remote is easier if you're a beginner.</li>
    </ul>
    <li><a href="#committing-guidelines">Committing Guidelines</a></li>
    <ul>
      <li>Writers and Artists can commit directly to the <strong>main branch</strong>, as long as they are not changing the <strong>00 Unity Proj</strong> folder.</li>
      <li>If you are curious, I explain in <a href="#branching--forking">Branching & Forking</a> section (optional).</li>
    </ul>
  </ol>

</div>

<p align="right">(<a href="#navigation">back to navigation</a>)</p>

<br></br> <!-- Spacer -->


<!-- FAMILIAR WITH GITHUB -->
<div id="familiar-with-github" style="font-size:16px;"> <!-- Link to Section -->
  <h2>Familiar With Github</h2>
  <p>Good to hear! With that said, here are the sections I would recommend you read:</p>
  <ol>
    <li><a href="#how-will-the-repository-be-used">How Will the Repository Be Used?</a></li>
    <li><a href="#remote-vs-local">Remote vs. Local</a></li>
    <ul>
      <li>May want to brush up on this if you don't know the difference between the remote and local repo.</li>
    </ul>
    <li><a href="#uploading-things--making-changes">Uploading Things & Making Changes</a></li>
    <ul>
      <li>If you are a Writer, Artist, or Designer, you can upload things <a href="#i-want-to-upload-files-through-my-browser-remote">remotely</a> or <a href="#i-want-to-upload-files-from-my-computer-local">locally</a>, your choice.
      <li>However, if you are a Programmer, you should upload <a href="#i-want-to-upload-files-from-my-computer-local">locally</a>.</li>
    </ul>
    <li><a href="#committing-guidelines">Committing Guidelines</a></li>
    <ul>
      <li>This section coincides with <a href="#push-origin">pushing</a> and <a href="#fetch-origin">pulling</a>.</li>
    </ul>
    <li><a href="#branching--forking">Branching & Forking</a></li>
    <ul>
      <li>Branching is the most important here, so please read carefully.</li>
      <li>You can fork if you want, but not required. Just thought I would distinguish the two.</li>
    </ul>
  </ol>

</div>

<p align="right">(<a href="#navigation">back to navigation</a>)</p>

<br></br> <!-- Spacer -->


<!-- REPOSITORIES -->
<div id="repositories" style="font-size:16px;"> <!-- Link to Section -->

<h2>Repositories</h2>

<!-- WHAT IS A REPOSITORY? -->
<div id="what-is-a-repository"> <!-- Link to Section -->

<h3>What Is a Repository?</h3>

A repository is what you are looking at right now! It's a central location where you can keep all of your files.

<img src="../00 Assets/getting-started/repository_def.png" style="padding-top: 5px; padding-bottom: 5px;" width="500"></img>

In the case of GitHub, we can all contribute to this same repository to track and synchronize our work, even when we're apart.

</div>
</div>

<p align="right">(<a href="#article-top">back to top</a>)</p>

<br> <!-- Spacer -->

<!-- HOW WILL THE REPOSITORY BE USED? -->
<div id="how-will-the-repository-be-used" style="font-size:16px;"> <!-- Link to Section -->

<h3>How Will the Repository Be Used?</h3>

You can interact with this repository <a href="#what-does-remote-mean">remotely through browser</a> or <a href="#what-does-local-mean">locally through your machine</a> via the [GitHub Desktop](https://desktop.github.com/download/) application.

You will make changes to the repository through <a href="#committing">**commits**</a> and <a href="#pull-requests">**pull requests**</a>.

The purpose behind this repository is to...

  <ol>
    <li>Quickly and easily share files</li>
    <li>Track progress and maintain an organized workflow</li>
    <li>Periodically create stable builds of our game</li>
    <li>Systematically identify and fix errors, *without* corrupting said builds</li>
    <li>Develop comprehensive and user-friendly documentation</li>
  </ol>

Please check out the sections below for all the information on this repository.

</div>

<p align="right">(<a href="#article-top">back to top</a>)</p>

<br></br> <!-- Spacer -->


<!-- COMMITTING -->
<div id="committing" style="font-size:16px;"> <!-- Link to Section -->
<h2>Committing</h2>

<!-- WHAT IS COMMITTING -->
<div id="what-is-committing"> <!-- Link to Section -->

<h3>What Is Committing?</h3>
Everytime you make changes to your repository, it is called a "commit."

Commits can be thought of as a 'Save Game' function.

<img src="../00 Assets/getting-started/quicksave_meme.png" style="padding-top: 5px; padding-bottom: 5px;" width="400"></img>

In the case of GitHub, they act as these little snapshots of your respository at specific times in its progression.

Just like in a video game, you should "save" your progress often by making new commits. This helps you and team members keep track of updates.

Additionally, in the event of project issues, you can roll back changes and return to a previous version of your project.

</div>
</div>

<p align="right">(<a href="#article-top">back to top</a>)</p>

<br> <!-- Spacer -->

<!-- HOW DO I COMMIT? -->
<div id="how-do-i-commit" style="font-size:16px;"> <!-- Link to Section -->

<h3>How Do I Commit?</h3>

There are two ways to commit to the GitHub:
1. Remotely through your browser
2. Locally from your machine

You can learn about the <a href="#remote-vs-local">differences between these methods</a> and <a href="#uploading-things--making-changes">how to follow them</a> in the sections below.

</div>

<p align="right">(<a href="#article-top">back to top</a>)</p>

<br></br> <!-- Spacer -->

<!-- REMOTE VS. LOCAL -->
<div id="remote-vs-local" style="font-size:16px;"> <!-- Link to Section -->
<h2>Remote vs. Local</h2>

<!-- WHAT DOES REMOTE MEAN? -->
<div id="what-does-remote-mean"> <!-- Link to Section -->

<h3>What Does Remote Mean?</h3>

"Remote" refers to a version of your project that is stored on a server everyone has access to (namely, the GitHub website).

It's like a shared Google Docs file versus a personal Word Doc. The remote repository is the shared Google Document that all team members can collaborate on in real time.

This workflow concept can be visualized through [this diagram](https://git-scm.com/book/en/v2/Getting-Started-About-Version-Control) from the official [Progit book](https://git-scm.com/book/en/v2).

<img src="../00 Assets/getting-started/centralized_ver_control_diagram.png" style="padding-top: 5px; padding-bottom: 5px;" width="600"></img>

However, this diagram *only* applies if you're making edits exclusively through the browser. If you want to make edits from your machine, take a look at the section below.

</div>
</div>

<p align="right">(<a href="#article-top">back to top</a>)</p>

<br> <!-- Spacer -->

<!-- WHAT DOES LOCAL MEAN? -->
<div id="what-does-local-mean" style="font-size:16px;"> <!-- Link to Section -->

<h3>What Does Local Mean?</h3>

In contrast, "Local" surrounds the idea of everything that is locally available to *you* and only you. In other words, your personal machine. The [diagram](https://git-scm.com/book/en/v2/Getting-Started-About-Version-Control) below illustrates this concept.

<img src="../00 Assets/getting-started/distributed_ver_control_sys.png" style="padding-top: 5px; padding-bottom: 5px;" width="500"></img>

As you can see, Computer A and Computer B both sync to the same remote repository, but have their own individual versions of the project. That way they can make changes and not corrupt the repository altogether. When you are ready, you can sync your local repository with the remote repository through <a href="#push-origin">pushing</a> and <a href="#fetch-origin">pulling</a>.

Note: To Programmers reading this, keep in mind that the workflow may be manipulated through different branches to ensure the stability of the project. As of right now, though, aforementioned concept illustrates the bare bones level of this project.

</div>

<p align="right">(<a href="#article-top">back to top</a>)</p>

<br></br> <!-- Spacer -->


<!-- UPLOADING THINGS & MAKING CHANGES -->
<div id="uploading-things-and-making-changes" style="font-size:16px;"> <!-- Link to Section -->

<h2>Uploading Things & Making Changes</h2>

Preface: If you are a Developer and you plan on making changes to the 00 Unity Proj folder, please see the <a href="#branching--forking">Branching & Forking</a> section.

<br> <!-- Spacer -->

<!-- I WANT TO UPLOAD FILES THROUGH MY BROWSER (REMOTE) -->
<div id="i-want-to-upload-files-through-my-browser-remote"> <!-- Link to Section -->

<h3>I Want to Upload Files Through My Browser (Remote)</h3>

The people committing remotely will most likely be Writers and Artists. To commit remotely, visit [this repository](https://github.com/Atomic-Atlas/MaS) on [GitHub.com](https://github.com/) and upload files to the correct folders.

<img src="../00 Assets/getting-started/create_or_upload.png" style="padding-top: 5px; padding-bottom: 5px;" width="600"></img>

Be sure to enter the <a href="#title-and-description">title and description</a> of your change.

<img src="../00 Assets/getting-started/summary_box_remote.png" style="padding-top: 5px; padding-bottom: 5px;" width="600"></img>

</div>

</div>

<p align="right">(<a href="#article-top">back to top</a>)</p>

<br> <!-- Spacer -->

<!-- I WANT TO UPLOAD FILES FROM MY COMPUTER (LOCAL) -->
<div id="i-want-to-upload-files-from-my-computer-local" style="font-size:16px;"> <!-- Link to Section -->

<h3>I Want to Upload Files From My Computer (Local)</h3>

The people committing locally will most likely be Programmers. To commit locally, use the [GitHub Desktop](https://desktop.github.com/download/) application.

It follows a very similar process, although it actively tracks your changes on your computer, and shows the difference between the remote repository (what's on the GitHub website) and the local repository (your machine).

Here is a screenshot of my local repository for *Murder at Supper* open on the GitHub Desktop app.

<img src="../00 Assets/getting-started/ghd_interface.png" style="padding-top: 5px; padding-bottom: 5px;" width="700"></img>

In the upper-left corner, right beneath the repository name, you can find the changes you've made. All changes will be selected automatically, but you can uncheck whatever you'd like to not be uploaded to the repository.

</div>

<p align="right">(<a href="#article-top">back to top</a>)</p>

<br> <!-- Spacer -->

<!-- FETCH ORIGIN -->
<div id="fetch-origin"> <!-- Link to Section -->

<h3>Fetch Origin</h3>

Sometimes it's best to pull from the repository ("fetch origin") before you push anything into it, which can be done by clicking the "Fetch Origin" button.

<img src="../00 Assets/getting-started/fetch_origin.png" style="padding-top: 5px; padding-bottom: 5px;" width="700"></img>

This takes in any new changes from the remote repository and adds them to your local repo.

</div>

<p align="right">(<a href="#article-top">back to top</a>)</p>

<br> <!-- Spacer -->

<!-- PUSH ORIGIN -->
<div id="push-origin"> <!-- Link to Section -->

<h3>Push Origin</h3>

Like the last method, you will be prompted to create a <a href="#title-and-description">title and description</a> for your commit.

If you are confident on these edits, and are ready to submit them to the main branch of the repository, you can click "Push Origin."

<img src="../00 Assets/getting-started/push_origin.png" style="padding-top: 5px; padding-bottom: 5px;" width="700"></img>

This command will sync your local and remote copies together.

</div>
</div>

<p align="right">(<a href="#article-top">back to top</a>)</p>

<br></br> <!-- Spacer -->

<!-- COMMITTING GUIDELINES -->
<div id="comitting-guidelines" style="font-size:16px;"> <!-- Link to Section -->
<h2>Comitting Guidelines</h2>

<!-- TITLE AND DESCRIPTION -->
<div id="title-and-description"> <!-- Link to Section -->
<h3>Title and Description</h3>

Regardless of which method you choose, you will always be prompted for a title and description of your changes. PLEASE, for your sake and everyone else's, add a description!

Adding a description will...
1. Eliminate the risk of forgetting what you were doing
2. Inform others of your changes (that way you don't have to reexplain yourself when you may be unavailable).
3. Make it easy to rollback changes.

</div>
</div>

<p align="right">(<a href="#article-top">back to top</a>)</p>

<br> <!-- Spacer -->

<!-- COMMIT EXAMPLE -->
<div id="commit-example" style="font-size:16px;"> <!-- Link to Section -->
<h3>Commit Example</h3>
Here is an example of what you might enter when you are making changes to the repository.

- **Title:** Created README<br>
- **Description:**
  - I created a README.md file at the root of the project.
  - This is intended to inform any viewers and contributors of what the project is about.
  - It contains:
    - Credits for Mista Bubble
    - Description of GitHub key terms
    - Information on how to interact with the repository
    - and more

Remember: you're *not* writing the declaration of independence. Just a brief overview of what changes you've made, why you made them, what might be incomplete, what needs revisions, etc.

If you're a Writer/Artist and you want to share your progress, you won't be uploading it directly to the 00 Unity Proj folder. You'll be sharing to the 01 Assets folder at the root of the repository ([see more](https://github.com/Nicole-Scalera/Bubble/blob/main/02%20Docs/01%20Information/uploading-to-assets.md)).

*However!!!!!* If you are a Programmer and/or you're making changes to files within 00 Unity Proj, please see the <a href="#branching--forking">Branching & Forking</a> section.

</div>

<p align="right">(<a href="#article-top">back to top</a>)</p>

</div>

<br></br> <!-- Spacer -->

<!-- BRANCHING & FORKING -->
<div id="branching-and-forking" style="font-size:16px;"> <!-- Link to Section -->
<h2>Branching & Forking</h2>

<!-- TO BRANCH, OR NOT TO BRANCH... -->
<div id="to-branch-or-not-to-branch"> <!-- Link to Section -->
<h3>To Branch, or Not to Branch...</h3>

Branching is an essential concept for the developer-side of things; namely, anyone working with the game's project files. For Writers and Artists, you can ignore this section and focus on committing to the main branch.

For anyone making changes to the 00 Unity Proj folder, please make sure your project is set to run on the `dev` branch. You can switch from `main` to `dev` in the GitHub Desktop application.

Changes that are made on `dev` can be turned into a pull request, which is then approved for merging into the `main` branch.

</div>
</div>

<p align="right">(<a href="#article-top">back to top</a>)</p>

<br> <!-- Spacer -->

<!-- WHY HAVE TWO DIFFERENT BRANCHES? -->
<div id="why-have-two-different-branches" style="font-size:16px;"> <!-- Link to Section -->
<h3>Why Have Two Different Branches?</h3>

We constantly have two primary branches that serve different purposes.

**Main Branch:** The `main` branch is like the home base of your repository. It is intended to track your latest stable project.

**Dev Branch:** The `dev` acts as an extension of `main`. It is designed to track your latest working project, while allowing you to add new features onto it.

God forbid anything crazy happens to your Unity files, it will *not* corrupt the main branch. You can think of it as cutting off the rotted piece of an apple. You still have the rest of the apple to work with.

</div>

<p align="right">(<a href="#article-top">back to top</a>)</p>

<br> <!-- Spacer -->

<!-- WHEN SHOULD I MERGE DEV INTO MAIN? -->
<div id="when-should-i-merge-dev-into-main" style="font-size:16px;"> <!-- Link to Section -->
<h3>When Should I Merge Dev Into Main?</h3>

After making a few changes to your game on `dev`, and the project is in a stable, playable state, you can go ahead and push the changes onto the `main` branch.

This will create a new stable version that can then be cloned again and worked on in `dev`. Working with several different branches allows you to build off of `main` without the risk of messing anything up.

</div>

<p align="right">(<a href="#article-top">back to top</a>)</p>

<br> <!-- Spacer -->

<!-- OTHER BRANCHES -->
<div id="other-branches" style="font-size:16px;"> <!-- Link to Section -->
<h3>Other Branches</h3>

Dev is not the only extension branch that you are allowed to use. In fact, I would encourage you to use more! This is what's known as "feature branching."

Different features, bugs, and any other kind of edits may require their own branch. For example, Programmer A may work on creating a narrative mechanic, while Programmer B is working on a fighting mechanic.

Likewise, Programmer A would be commmitting changes to the `dialogue-loop` branch, while Programmer B would commit changes to the `combat-kick-feature` branch. Once each of them are confident on their changes, they would merge that branch with the `main` branch.

</div>

<p align="right">(<a href="#article-top">back to top</a>)</p>

<br> <!-- Spacer -->

<!-- WHAT THE FORK?! -->
<div id="what-the-fork" style="font-size:16px;"> <!-- Link to Section -->
<h3>What the Fork?!</h3>

Forking is a common term used on GitHub, and it surrounds the idea of creating a whole new repository that is a copy of another one. This is seperate from a local and remote repository, as the two separate pieces (local and remote) are connected under one larger repository.

You can fork this repository if you want to make some big changes on your own without directly affecting the original repository, but it's not needed. I just wanted to let you know that this option was here for any big changes that you wanted to make, which can be completed *without* harming the project entirely.

Forking is better for experimentation. But if you are planning on making something that you will use in later stages of the project, you will want to go with branching.

</div>

<p align="right">(<a href="#article-top">back to top</a>)</p>

<br></br> <!-- Spacer -->

<!-- ACKNOWLEDGMENTS -->
<div id="acknowledgments" style="font-size:16px;"> <!-- Link to Section -->
<h2>Acknowledgments</h2>

* This README was authored by Nicole Scalera ([Nicole-Scalera](https://github.com/Nicole-Scalera)).
* I started this README file thru a template from the popular repository, [Best-README-Template](https://github.com/othneildrew/Best-README-Template), by [othneildrew](https://github.com/othneildrew) on GitHub.
* I altered a bunch for one of my previous projects, [_Murder at Supper_](https://github.com/Nicole-Scalera/MaS).
* Being that most of the content is still very relevant and helpful, I adapted it for _Mista Bubble_ as well.

</div>

<p align="right">(<a href="#article-top">back to top</a>)</p>